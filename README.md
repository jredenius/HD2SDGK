# HD2SDGK
Helldivers 2 Stratagem selector for Stream Deck (Mini)

Release: https://github.com/jredenius/HD2SDGK/releases

The program will update your Stream Deck with your selected Stratagems using the included Stream Deck Mini profile.

Setup Instructions:
1) Add the HD2SDGK profile to your Stream Deck
   - Set it as default or to auto when Helldivers 2 is running.
3) Make sure Stream Deck is running.
4) Run the HD2SDGK program.
5) In game, open Steam Overlay and add a browser component.
6) Navigate the browser to http://localhost:4567.
   - Port is configurable in .config file.
7) On the website, select your Stratagems to match the ones you choose in game.
8) Click the Update Stream Deck button
   - The profile will be overwritten.
   - The Stream Deck applicaiton will restart.
   - After about 3 seconds, the Kit buttons will now show your selected Stratagems and include the keybind combo.
9) Close the Steam Overlay.

Notes:
1) Keybind combos utilizise Home + Arrowkeys. This is not currently changable.
3) You can use your own profile instead of the one included.
     - You must have buttons in your profile that are Multi Action type and have a title set to Kit# (e.g. Kit1, Kit2, +).
     - The program will not interfere with your other buttons.
     - Edit the HD2SDGK.config to change profileName.
     - profileButtons list must match your button names.
4) In HD2SDGK.config, selectorRows/Colums affects the webpage layout.

StratConfig.json contains the key combos. I'll try to keep this up-to-date as new Strats are release. You will be able to download the new copy and replace the old one. 
If you want to modify this yourself:
1) Add a new item under "strats" in your prefered category.
2) The name doesn't have to match the in-game strat name, but there must be an .png image that matches the name used in the config in the StratImages folder.
3) Leave the "image" property set to an empty string. This is populated automatically when the program starts.
4) Set the key combo using the Home + Direction keywords.

![image](https://github.com/jredenius/HD2SDGK/assets/22848915/8040c5eb-d337-42ec-8577-f17c9715f859)
