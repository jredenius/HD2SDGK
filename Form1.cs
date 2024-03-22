using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SelfishHttp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace HD2SDGK
{
    public partial class Form1 : Form
    {
        AppConfig appConfig;
        string _imageFolder = "StratImages";
        StratCats StratConfig;
        SDButtonProfileDir SDButtonProfile = new SDButtonProfileDir();
        IEnumerable<StratItem> StratItems { get { return StratConfig.categories.SelectMany(x => x.strats); } }
        Server httpServer;
        bool httpServerIsStarted = false;
        public string ConfigWebPageContent { get; set; } = "";
        public string ConfigStratJSONContent { get; set; } = "";
        bool SDAppRunning = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*TODO
             * Auto update strat list from offical source
             * 
             */
            bool _error = false;
            try
            {
                LoadAppConfig();
                if (appConfig == null) _error = true;
            }
            catch (Exception)
            {
                _error = true;
            }
            if(_error)
            {
                log("HD2SDGK.config not found.");
                return;
            }
            try
            {
                LoadWebPageContent();
                lbWebInterface.Text = "Loaded";
                lbWebInterface.ForeColor = Color.Green;
            }
            catch (Exception)
            {
                lbWebInterface.Text = "Error";
                lbWebInterface.ForeColor = Color.Red;
            }
            try
            {
                LoadStratConfig();
                lbStratcombos.Text = "Loaded";
                lbStratcombos.ForeColor = Color.Green;
            }
            catch (Exception)
            {
                lbStratcombos.Text = "Error";
                lbStratcombos.ForeColor = Color.Red;
            }
            try
            {
                LoadImageHashs();
                lbStratimages.Text = "Loaded";
                lbStratimages.ForeColor = Color.Green;
            }
            catch (Exception)
            {
                lbStratimages.Text = "Error";
                lbStratimages.ForeColor = Color.Red;
            }
            try
            {
                SaveStratConfig();
                lbConfig.Text = "Updated";
                lbConfig.ForeColor = Color.Green;
            }
            catch (Exception)
            {
                lbConfig.Text = "Error";
                lbConfig.ForeColor = Color.Red;
            }
            try
            {
                LoadSDButtonImages();
                lbSDinfo.Text = "Located";
                lbSDinfo.ForeColor = Color.Green;
            }
            catch (Exception)
            {
                lbSDinfo.Text = "Error";
                lbSDinfo.ForeColor = Color.Red;
            }
            try
            {
                UpdateWebContent();
            }
            catch (Exception)
            {

            }


            try
            {
                httpServer = new Server(appConfig.localHostPort);
                httpServerIsStarted = true;
                httpServer.OnGet("/").NoCache().RespondWith(ConfigWebPageContent);
                httpServer.OnGet("/StratConfig.json").NoCache().RespondWith(ConfigStratJSONContent);
                httpServer.OnGet("/HD2SDGK.config").NoCache().RespondWith(JsonConvert.SerializeObject(appConfig));
                foreach (string kitName in appConfig.profileButtons)
                {
                    httpServer.OnGet("/"+ kitName).AddHandler(new Action<HttpListenerContext, Action>(KitAction));
                }
                httpServer.OnGet("/ResetSD").AddHandler(new Action<HttpListenerContext, Action>(ResetSDAction));
                lbEvents.Text = "Listening";
                lbEvents.ForeColor = Color.Green;
            }
            catch (Exception)
            {
                lbEvents.Text = "Error";
                lbEvents.ForeColor = Color.Red;
            }
            Task.Delay(500).ContinueWith((task) =>
            {
                log("Ready...");
            });
        }
        private void LoadAppConfig()
        {
            FileInfo config = new FileInfo("HD2SDGK.config");
            if (config.Exists)
            {
                try
                {
                    using (StreamReader r = new StreamReader(config.FullName))
                    {
                        appConfig = JsonConvert.DeserializeObject<AppConfig>(r.ReadToEnd());
                    }
                }
                catch { }
            }
        }
        private void UpdateWebContent()
        {
            string imageKVP = "";
            foreach (SDButtonProfileButton button in SDButtonProfile.Kits.Values)
            {
                if (SDButtonProfile.Kits.ContainsKey(button.name))
                {
                    imageKVP += button.name;
                    imageKVP += ": \"";
                    imageKVP += GetImageBase64(SDButtonProfile.Kits[button.name].image);
                    imageKVP += "\",";
                }
            }
            ConfigWebPageContent = ConfigWebPageContent.Replace("$kitImages", imageKVP);
        }
        private void log(string message)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                if (Logtb.TextLength > 2000) Logtb.Text = "..." + Logtb.Text.Substring(1000);
                Logtb.AppendText(message);
                Logtb.AppendText(Environment.NewLine);
            }));
        }
        private void LoadSDButtonImages()
        {
            string SDAppPath = appConfig.streamDeckAppdataPath + "\\ProfilesV2";
            SDAppPath = SDAppPath.Replace("%AppData%", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            DirectoryInfo profileDir = new DirectoryInfo(SDAppPath);
            log("Searching Stream Deck profiles.");
            foreach (DirectoryInfo sub in profileDir.GetDirectories())
            {
                FileInfo manifest = sub.GetFiles("manifest.json", SearchOption.TopDirectoryOnly).FirstOrDefault<FileInfo>();
                if (manifest != null)
                {
                    using (StreamReader r = new StreamReader(manifest.FullName))
                    {
                        dynamic _manifest = JsonConvert.DeserializeObject(r.ReadToEnd());
                        if (_manifest == null)
                        {
                            continue;
                        }
                        else if (_manifest.Name == "HD2SDGK")
                        {
                            SDButtonProfile.name = sub.Name;
                            SDButtonProfile.location = sub.FullName;
                            SDButtonProfile.pages = _manifest.Pages.Pages.ToObject<string[]>();
                            log("> HD2SDGK profile identified.");
                            break;
                        }
                    }
                }
            }
            DirectoryInfo profile_pageDir = new DirectoryInfo(SDButtonProfile.location + "\\Profiles\\");
            foreach (DirectoryInfo pagedir in profile_pageDir.GetDirectories())
            {
                FileInfo page_manifest = new FileInfo(pagedir.FullName + "\\manifest.json");
                if (page_manifest.Exists)
                {
                    using (StreamReader r = new StreamReader(page_manifest.FullName))
                    {
                        string manifest_content = r.ReadToEnd();
                        dynamic manifest = JsonConvert.DeserializeObject(manifest_content);
                        foreach (string kitName in appConfig.profileButtons)
                        {
                            if (manifest_content.Contains("\"" + kitName + "\""))
                            {
                                try
                                {
                                    foreach (dynamic buttons in manifest.Controllers[0].Actions)
                                    {
                                        foreach (dynamic button in buttons)
                                        {
                                            if (button.States[0].Title == kitName)
                                            {
                                                //[btnLocation].Actions[0].Actions = actions;
                                                string buttonImage = GenerateProfileImageFileName(pagedir.FullName, (string)button.States[0].Image);
                                                SDButtonProfile.Kits.Add(kitName, new SDButtonProfileButton()
                                                {
                                                    name = kitName,
                                                    location = page_manifest.FullName,
                                                    image = buttonImage
                                                });
                                                log("> " + kitName + " identified");
                                                break;
                                            }
                                        }
                                    }
                                }
                                catch (Exception)
                                {
                                    log("> Error identifying "+ kitName + ".");
                                }
                            }
                        }
                    }
                }
            }
        }
        private void SaveStratConfig()
        {
            using (StreamWriter w = new StreamWriter("StratConfig.json"))
            {
                ConfigStratJSONContent = JsonConvert.SerializeObject(StratConfig);
                w.Write(ConfigStratJSONContent);
                w.Flush();
                log("Strat config file updated.");
            }
        }
        private string GetImageBase64(string filePath)
        {
            using (var ms = new MemoryStream())
            {
                try
                {
                    Image img = Image.FromFile(filePath);
                    img.Save(ms, img.RawFormat);
                    byte[] imageBytes = ms.ToArray();
                    string base64String = Convert.ToBase64String(imageBytes);
                    img.Dispose();
                    return base64String;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        private void LoadImageHashs()
        {
            DirectoryInfo imageFolder = new DirectoryInfo(_imageFolder);
            foreach (StratCat cat in StratConfig.categories)
            {
                cat.image = GetImageBase64(string.Concat(Directory.GetCurrentDirectory(), "\\", _imageFolder, "\\", cat.name, ".png"));
                foreach (StratItem item in cat.strats)
                {
                    item.image = GetImageBase64(string.Concat(Directory.GetCurrentDirectory(), "\\", _imageFolder, "\\", item.name, ".png"));
                }
            }
            log("Strat images updated.");
        }
        private void LoadWebPageContent()
        {
            using (StreamReader r = new StreamReader("index.html"))
            {
                ConfigWebPageContent = r.ReadToEnd();
            }
            log("Web interface updated.");
        }
        private void LoadStratConfig()
        {
            using (StreamReader r = new StreamReader("StratConfig.json"))
            {
                ConfigStratJSONContent = r.ReadToEnd();
                StratConfig = JsonConvert.DeserializeObject<StratCats>(ConfigStratJSONContent);
            }
            log("Strat config imported.");
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ResetProfileImages();
            try
            {
                if (httpServerIsStarted)
                {
                    httpServer.Stop();
                    //httpServer.Dispose();
                }
            }
            catch (Exception)
            {
            }
        }
        private void ResetProfileImages()
        {
            FileInfo blankImage = new FileInfo(GenerateStratImageFileName("blank"));
            foreach (SDButtonProfileButton button in SDButtonProfile.Kits.Values)
            {
                try
                {
                    blankImage.CopyTo(button.image, true);
                }
                catch (Exception)
                {

                }
                log("Profile button images reset to blank.");
            }
        }
        private StratItem SetSDAction(string kitName, string stratname, string imagePath, string manifestPath)
        {
            string stratRequestName = stratname;
            StratItem strat = StratItems.Where(x => x.name == stratRequestName).FirstOrDefault();

            if (strat != null)
            {
                log(string.Format("Updating {0} to {1}", kitName, stratname));
                //set kit
                FileInfo newImage = new FileInfo(GenerateStratImageFileName(strat.name));
                newImage.CopyTo(imagePath, true);
                dynamic manifest;
                //using (StreamReader r = new StreamReader(SDButtonProfile.Page1Manifest))
                using (FileStream fs = new FileStream(manifestPath, FileMode.Open, FileAccess.ReadWrite, FileShare.Read))
                using (StreamReader r = new StreamReader(fs))
                using (StreamWriter w = new StreamWriter(fs))
                {
                    manifest = JsonConvert.DeserializeObject(r.ReadToEnd());
                    if (manifest != null)
                    {
                        JArray actions = new JArray();// [strat.code.Length];
                        for (int i = 0; i < strat.code.Length; i++)
                        {
                            switch (strat.code[i].ToUpper())
                            {
                                case "HOME":
                                    //actions[i] = StratCode.Home;
                                    actions.Add(StratCode.Home);
                                    break;
                                case "UP":
                                    //actions[i] = StratCode.Up;
                                    actions.Add(StratCode.Up);
                                    break;
                                case "DOWN":
                                    //actions[i] = StratCode.Down;
                                    actions.Add(StratCode.Down);
                                    break;
                                case "LEFT":
                                    //actions[i] = StratCode.Left;
                                    actions.Add(StratCode.Left);
                                    break;
                                case "RIGHT":
                                    //actions[i] = StratCode.Right;
                                    actions.Add(StratCode.Right);
                                    break;
                                default:
                                    break;
                            }

                        }
                        foreach (dynamic buttons in manifest.Controllers[0].Actions)
                        {
                            foreach (dynamic button in buttons)
                            {
                                if (button.States[0].Title == kitName)
                                {
                                    button.Actions[0].Actions = actions;
                                    break;
                                }
                            }
                        }
                        fs.SetLength(0);
                        w.Write(JsonConvert.SerializeObject(manifest));
                        log("> Button macro saved.");
                    }
                }
                return strat;
            }
            return null;
        }
        private void ResetSDAction(HttpListenerContext c, Action a)
        {
            log("Resetting Stream Deck.");
            if (SDAppRunning)
            {
                Process[] SDProcesses = Process.GetProcessesByName("StreamDeck");
                if(SDProcesses.Length > 0 )
                {
                    Process SDProcess = SDProcesses[0];
                    SDProcess.Kill(true);
                    SDAppRunning = false;
                    log("> Process Ended");
                    SDProcess.WaitForExit();

                    Process p = new Process();
                    p.StartInfo = new ProcessStartInfo(appConfig.streamDeckExePath);
                    //p.StartInfo.WorkingDirectory = @"C:\Program Files\Elgato\StreamDeck\";
                    p.StartInfo.Arguments = @"--runinbk";
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.UseShellExecute = false;
                    p.Start();
                    SDAppRunning = true;
                    log("> Process Restarted.");
                } 
                else
                {
                    log("> Process not found.");
                }
                //Task.Delay(1000).ContinueWith((task) =>
                //{
                //    if (!SDAppRunning)
                //    {
                //    }
                //});
            }
            else
            {
                log("> Process already closed.");
            }
        }
        private void KitAction(HttpListenerContext c, Action a)
        {
            SDButtonProfileButton button = SDButtonProfile.Kits[c.Request.Url.LocalPath.Remove(0, 1)];
            button.stratItem = SetSDAction(button.name, c.Request.QueryString["strat"], button.image, button.location);
        }
        private string GenerateStratImageFileName(string Name)
        {
            string relativePath = string.Concat("\\", _imageFolder, "\\", Name, ".png");
            FileInfo file = new FileInfo(Directory.GetCurrentDirectory() + relativePath);
            if (file.Exists)
            {
                return file.FullName;
            }
            return null;
        }
        private string GenerateProfileImageFileName(string path, string Name)
        {
            FileInfo file = new FileInfo(string.Concat(path, "\\", Name).Replace("/", "\\"));
            if (file.Exists)
            {
                return file.FullName;
            }
            return null;
        }

    }
}