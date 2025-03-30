<p align="center">
    <a href="https://github.com/codecorno/PBLauncher/tree/master/Loading">
        <img src="https://github.com/codecorno/PBLauncher/blob/master/Loading/PointBlank_intro.bmp" />
    </a>
</p>

<p align="center">
    PBLauncher for PBServer v3.24
    <br />
    <a href="https://github.com/codecorno/PBLauncher-v3.24"><strong>Acessar »</strong></a>
    <br />
  </p>
</p>

# PBLauncher Public Version - Easy setup
> Public launcher dedicated to private servers | Public launcher dedicated to private servers

# Features
* Game file update system
* PBLauncher.exe update system, using Assembly.ProductVersion
* Game startup with support for Xigncode_Loader
* Custom message system for maintenance or launch alerts
* LauncherKey via host
* Malicious program detection system (can be improved)
* Launcher access ban system (can be improved)
* Simple and easy launcher configuration, all in one file
# New Feature
* Change Language System
* Banned IP Computer And Other
* Login System Any Version

# Settings
* In your site's htdocs, place the 'launcher' folder.
* Edit the launch settings in the 'settings.conf' file and save with UTF-8 encoding. * Open the project in visual studio, look for the 'Connect.cs' file, enter the name of your project and the URL of 'settings.conf', compile, if everything goes without errors, the launcher will be ready to use.
  
[Status]
1= Maintenance
2= Maintenance + Alert
3= Normal start
4= Normal start + Alert

[Notice]
Write any text in the file that you want to announce to the players.
Change a status that has '+ alert'
*If the alert is empty, the status will be adjusted automatically and nothing will be displayed.

The Alert will appear each time the player opens the launcher until the status returns to 3.

[Updates]
Mount the update as it will be in the game root and zip it with Windows Explorer in .zip (required)
with the following name "patch_VERSION OF ATT", example:
Update 1 the name of the file will be "patch_1.zip" and in config.zpt put 1 as well.
Place config.zpt inside patch_1.zip, it must be without folders, as it will be in the root.
After that, to release the update, put 1 in settings.conf in 'clientversion'

EX: FOLDER structure to update the game's '\config\' and 2 random packs!

patch_1.zip
├──\config.zpt
│ *inside should be 'version=1'
├──\Config
│ └──\lwsi_En.sif
└──\Pack
├──\pack_da_aug.i3Pack
└──\segundo_pack.i3pack

IMPORTANT:
NEVER GO BACK a version, like 10 going back to 9, this will reset the order and cause errors!

DO NOT change the 'clientversion' version without having the file with the version too! NEVER forget the config.zpt or enter the wrong version, it will cause an infinite update loop.
Follow the count in order (1, 2, 3, 4...)

```
