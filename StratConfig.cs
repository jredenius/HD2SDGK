using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HD2SDGK
{
    public class AppConfig
    {
        public string profileName;
        public int localHostPort;
        public string[] profileButtons;
        public string streamDeckAppdataPath;
        public string streamDeckExePath;
        public int selectorRows;
        public int selectorColumns;
        public string stratConfigUpdateURL;
    }
    public class StratCats
    {
        public DateTime lastUpdated;
        public List<StratCat> categories;
    }
    public class StratCat
    {
        public string name;
        public string image;
        public List<StratItem> strats;
    }

    public class StratItem
    {
        public string name;
        public string image;
        public string[] code;
    }

    public class SDButtonProfileDir
    {
        public string name;
        public string location;
        public string[] pages;
        public Dictionary<string, SDButtonProfileButton> Kits = new Dictionary<string, SDButtonProfileButton>();
    }
    public class SDButtonProfileButton
    {
        public string name;
        public string image;
        public string location;
        public StratItem stratItem;
    }
    public static class StratCode
    {
        public static dynamic Home
        {
            get
            {
                return JsonConvert.DeserializeObject(@"{
                                    ""ActionID"": ""e4435707-517c-44e4-a81f-435379643223"",
                                    ""LinkedTitle"": true,
                                    ""Name"": ""Hotkey"",
                                    ""Settings"": {
                                        ""Coalesce"": true,
                                        ""Hotkeys"": [
                                            {
                                                ""KeyCmd"": false,
                                                ""KeyCtrl"": false,
                                                ""KeyModifiers"": 0,
                                                ""KeyOption"": false,
                                                ""KeyShift"": false,
                                                ""NativeCode"": 36,
                                                ""QTKeyCode"": 16777232,
                                                ""VKeyCode"": 36
                                            },
                                            {
                                                ""KeyCmd"": false,
                                                ""KeyCtrl"": false,
                                                ""KeyModifiers"": 0,
                                                ""KeyOption"": false,
                                                ""KeyShift"": false,
                                                ""NativeCode"": 146,
                                                ""QTKeyCode"": 33554431,
                                                ""VKeyCode"": -1
                                            },
                                            {
                                                ""KeyCmd"": false,
                                                ""KeyCtrl"": false,
                                                ""KeyModifiers"": 0,
                                                ""KeyOption"": false,
                                                ""KeyShift"": false,
                                                ""NativeCode"": 146,
                                                ""QTKeyCode"": 33554431,
                                                ""VKeyCode"": -1
                                            },
                                            {
                                                ""KeyCmd"": false,
                                                ""KeyCtrl"": false,
                                                ""KeyModifiers"": 0,
                                                ""KeyOption"": false,
                                                ""KeyShift"": false,
                                                ""NativeCode"": 146,
                                                ""QTKeyCode"": 33554431,
                                                ""VKeyCode"": -1
                                            }
                                        ]
                                    },
                                    ""State"": 0,
                                    ""States"": [
                                        {
                                            ""Title"": ""Home""
                                        }
                                    ],
                                    ""UUID"": ""com.elgato.streamdeck.system.hotkey""
                                }");
            }
        }
        public static dynamic Up
        {
            get
            {
                return JsonConvert.DeserializeObject(@"{
                                    ""ActionID"": ""a4e399c9-390d-41c9-ab24-9e2b698e4587"",
                                    ""LinkedTitle"": true,
                                    ""Name"": ""Hotkey"",
                                    ""Settings"": {
                                        ""Coalesce"": true,
                                        ""Hotkeys"": [
                                            {
                                                ""KeyCmd"": false,
                                                ""KeyCtrl"": false,
                                                ""KeyModifiers"": 0,
                                                ""KeyOption"": false,
                                                ""KeyShift"": false,
                                                ""NativeCode"": 38,
                                                ""QTKeyCode"": 16777235,
                                                ""VKeyCode"": 38
                                            },
                                            {
                                                ""KeyCmd"": false,
                                                ""KeyCtrl"": false,
                                                ""KeyModifiers"": 0,
                                                ""KeyOption"": false,
                                                ""KeyShift"": false,
                                                ""NativeCode"": 146,
                                                ""QTKeyCode"": 33554431,
                                                ""VKeyCode"": -1
                                            },
                                            {
                                                ""KeyCmd"": false,
                                                ""KeyCtrl"": false,
                                                ""KeyModifiers"": 0,
                                                ""KeyOption"": false,
                                                ""KeyShift"": false,
                                                ""NativeCode"": 146,
                                                ""QTKeyCode"": 33554431,
                                                ""VKeyCode"": -1
                                            },
                                            {
                                                ""KeyCmd"": false,
                                                ""KeyCtrl"": false,
                                                ""KeyModifiers"": 0,
                                                ""KeyOption"": false,
                                                ""KeyShift"": false,
                                                ""NativeCode"": 146,
                                                ""QTKeyCode"": 33554431,
                                                ""VKeyCode"": -1
                                            }
                                        ]
                                    },
                                    ""State"": 0,
                                    ""States"": [
                                        {
                                            ""Title"": ""Up""
                                        }
                                    ],
                                    ""UUID"": ""com.elgato.streamdeck.system.hotkey""
                                }");
            }
        }
        public static dynamic Down
        {
            get
            {
                return JsonConvert.DeserializeObject(@"{
                                    ""ActionID"": ""92c0a595-d3a9-4744-9bdb-9649fdf48c28"",
                                    ""LinkedTitle"": true,
                                    ""Name"": ""Hotkey"",
                                    ""Settings"": {
                                        ""Coalesce"": true,
                                        ""Hotkeys"": [
                                            {
                                                ""KeyCmd"": false,
                                                ""KeyCtrl"": false,
                                                ""KeyModifiers"": 0,
                                                ""KeyOption"": false,
                                                ""KeyShift"": false,
                                                ""NativeCode"": 40,
                                                ""QTKeyCode"": 16777237,
                                                ""VKeyCode"": 40
                                            },
                                            {
                                                ""KeyCmd"": false,
                                                ""KeyCtrl"": false,
                                                ""KeyModifiers"": 0,
                                                ""KeyOption"": false,
                                                ""KeyShift"": false,
                                                ""NativeCode"": 146,
                                                ""QTKeyCode"": 33554431,
                                                ""VKeyCode"": -1
                                            },
                                            {
                                                ""KeyCmd"": false,
                                                ""KeyCtrl"": false,
                                                ""KeyModifiers"": 0,
                                                ""KeyOption"": false,
                                                ""KeyShift"": false,
                                                ""NativeCode"": 146,
                                                ""QTKeyCode"": 33554431,
                                                ""VKeyCode"": -1
                                            },
                                            {
                                                ""KeyCmd"": false,
                                                ""KeyCtrl"": false,
                                                ""KeyModifiers"": 0,
                                                ""KeyOption"": false,
                                                ""KeyShift"": false,
                                                ""NativeCode"": 146,
                                                ""QTKeyCode"": 33554431,
                                                ""VKeyCode"": -1
                                            }
                                        ]
                                    },
                                    ""State"": 0,
                                    ""States"": [
                                        {
                                            ""Title"": ""Down""
                                        }
                                    ],
                                    ""UUID"": ""com.elgato.streamdeck.system.hotkey""
                                }");
            }
        }
        public static dynamic Left
        {
            get
            {
                return JsonConvert.DeserializeObject(@"{
                                    ""ActionID"": ""0b783612-42a5-478b-be89-5fa76adaa3b9"",
                                    ""LinkedTitle"": true,
                                    ""Name"": ""Hotkey"",
                                    ""Settings"": {
                                        ""Coalesce"": true,
                                        ""Hotkeys"": [
                                            {
                                                ""KeyCmd"": false,
                                                ""KeyCtrl"": false,
                                                ""KeyModifiers"": 0,
                                                ""KeyOption"": false,
                                                ""KeyShift"": false,
                                                ""NativeCode"": 37,
                                                ""QTKeyCode"": 16777234,
                                                ""VKeyCode"": 37
                                            },
                                            {
                                                ""KeyCmd"": false,
                                                ""KeyCtrl"": false,
                                                ""KeyModifiers"": 0,
                                                ""KeyOption"": false,
                                                ""KeyShift"": false,
                                                ""NativeCode"": 146,
                                                ""QTKeyCode"": 33554431,
                                                ""VKeyCode"": -1
                                            },
                                            {
                                                ""KeyCmd"": false,
                                                ""KeyCtrl"": false,
                                                ""KeyModifiers"": 0,
                                                ""KeyOption"": false,
                                                ""KeyShift"": false,
                                                ""NativeCode"": 146,
                                                ""QTKeyCode"": 33554431,
                                                ""VKeyCode"": -1
                                            },
                                            {
                                                ""KeyCmd"": false,
                                                ""KeyCtrl"": false,
                                                ""KeyModifiers"": 0,
                                                ""KeyOption"": false,
                                                ""KeyShift"": false,
                                                ""NativeCode"": 146,
                                                ""QTKeyCode"": 33554431,
                                                ""VKeyCode"": -1
                                            }
                                        ]
                                    },
                                    ""State"": 0,
                                    ""States"": [
                                        {
                                            ""Title"": ""Left""
                                        }
                                    ],
                                    ""UUID"": ""com.elgato.streamdeck.system.hotkey""
                                }");
            }
        }
        public static dynamic Right
        {
            get
            {
                return JsonConvert.DeserializeObject(@"{
                                    ""ActionID"": ""789213d0-041a-48ef-b5aa-96776e3a7509"",
                                    ""LinkedTitle"": true,
                                    ""Name"": ""Hotkey"",
                                    ""Settings"": {
                                        ""Coalesce"": true,
                                        ""Hotkeys"": [
                                            {
                                                ""KeyCmd"": false,
                                                ""KeyCtrl"": false,
                                                ""KeyModifiers"": 0,
                                                ""KeyOption"": false,
                                                ""KeyShift"": false,
                                                ""NativeCode"": 39,
                                                ""QTKeyCode"": 16777236,
                                                ""VKeyCode"": 39
                                            },
                                            {
                                                ""KeyCmd"": false,
                                                ""KeyCtrl"": false,
                                                ""KeyModifiers"": 0,
                                                ""KeyOption"": false,
                                                ""KeyShift"": false,
                                                ""NativeCode"": 146,
                                                ""QTKeyCode"": 33554431,
                                                ""VKeyCode"": -1
                                            },
                                            {
                                                ""KeyCmd"": false,
                                                ""KeyCtrl"": false,
                                                ""KeyModifiers"": 0,
                                                ""KeyOption"": false,
                                                ""KeyShift"": false,
                                                ""NativeCode"": 146,
                                                ""QTKeyCode"": 33554431,
                                                ""VKeyCode"": -1
                                            },
                                            {
                                                ""KeyCmd"": false,
                                                ""KeyCtrl"": false,
                                                ""KeyModifiers"": 0,
                                                ""KeyOption"": false,
                                                ""KeyShift"": false,
                                                ""NativeCode"": 146,
                                                ""QTKeyCode"": 33554431,
                                                ""VKeyCode"": -1
                                            }
                                        ]
                                    },
                                    ""State"": 0,
                                    ""States"": [
                                        {
                                            ""Title"": ""Right""
                                        }
                                    ],
                                    ""UUID"": ""com.elgato.streamdeck.system.hotkey""
                                }");
            }
        }
    }
}
