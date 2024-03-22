# HD2SDGK
Helldivers 2 Stratagem selector for Stream Deck.

Release: https://github.com/jredenius/HD2SDGK/releases
[![Github All Releases](https://img.shields.io/github/downloads/jredenius/HD2SDGK/total.svg)]()

The program will update your Stream Deck with your selected Stratagems using a locally hosted web interface. 
Use the included Stream Deck Mini profile or modify your own.

=======================================================================

Setup Instructions:
1) Add the HD2SDGK profile to your Stream Deck
   - Set it as default or to auto when Helldivers 2 is running.
2) Make sure Stream Deck is running.
3) Run the HD2SDGK program.
4) In game, open Steam Overlay and add a browser component.
5) Navigate the browser to http://localhost:4567.
   - Port is configurable in .config file.
6) On the web interface, select your Stratagems to match the ones you choose in game.
7) Click the Update Stream Deck button.
   - The profile will be overwritten.
   - The Stream Deck applicaiton will restart.
   - After about 3 seconds, the Kit buttons will now show your selected Stratagems and include the keybind combo.
8) Close the Steam Overlay. You can close the overlay immediately after clicking the Update button, you don't have to wait for the Deck to update.

=======================================================================

Tips:
1) The web interface works the same in-game or out. It's just easier to use Steam Overlay so you don't have to tab out of the game.
2) If you open the Steam Overlay when you are readying-up for the mission, you can see your selected strats through the background.
     - However, you can use the web interface to update the Stream Deck at any time, including in-mission.
3) Use additional Kit buttons when there are effects that give you free Stratagems.

=======================================================================

Notes:
1) Keybind combos utilizise Home + Arrowkeys. This is not currently changable.
2) You can use your own profile instead of the one included.
     - You must have buttons in your profile that are Multi Action type and have a title set to Kit# (e.g. Kit1, Kit2, +).
     - The program will not interfere with your other buttons.
     - Edit HD2SDGK.config
        - Change profileName to match your profile.
        - profileButtons list must match your profile button names (e.g. Kit1, Kit2, etc.).
3) In HD2SDGK.config, selectorRows/Colums affects the webpage layout.

=======================================================================

StratConfig.json contains the key combos. I'll try to keep this up-to-date as new Strats are release. You will be able to download the new copy and replace the old one. 

If you want to modify this yourself:
1) Add a new item under "strats" in your prefered category.
2) The name doesn't have to match the in-game strat name, but there must be an .png image that matches the name used in the config in the StratImages folder.
3) Leave the "image" property set to an empty string. This is populated automatically when the program starts.
4) Set the key combo using the Home + Direction keywords.

=======================================================================
![image](https://github.com/jredenius/HD2SDGK/assets/22848915/b3fbe1a0-d6e9-4747-9569-08308601b1b2)

![image](https://github.com/jredenius/HD2SDGK/assets/22848915/8040c5eb-d337-42ec-8577-f17c9715f859)
