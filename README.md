# Archived

PlateUp-Package-Manager has now been archived as PlateUp! is now on the Steam Workshop, and this manager has no remaining use.

# PlateUp-Package-Manager (PPM)

## Description

PlateUp Package Manager (PPM) is designed to make PlateUp modding much easier with the ability for third parties to setup repositories that you're able to pull mods from!

## Installation

- To install PlateUp-Package-Manager, you need to extract `PlateUp.Package.Manager.zip` into an empty directory, and start `Launcher.exe`

## Usage

### Setup

On first launch of PPM, you will be asked for your `/PlateUp` directory. (PPM will try to find this automatically)

Once you've completed the first-launch set, you'll be put into your `Home` menu, go and have a look around!

### Navigation

No matter where you are in PPM, you will always have access to the Navigation Bar at the bottom of the screen

There are a number of different menus you can access here: `Home`, `Repositories`, `Installed`, `Search`, and `Settings`

### Home

Your `Home` menu contains some basic information about PPM, as well as a couple buttons.

`Clean` Will clean your `/PlateUp` directory and remove all signs of any previous or current mods.

`Builder` Is used for Mod Developers to help packaging their mods into `.plateupmod` files.

### Repositories

Your `Repositories` menu is where you manage the different Repositories you can download packages from.

Some first party Repositories are `http://plateup.starfluxgames.com/Repo` and `http://plateup.starfluxgames.com/BepInEx`

### Installed

Your `Installed` menu is where you can manage your installed packages.

`Toggle` is used to toggle on/off an already installed package, you aren't required to re-download packages. 

`Manual` is used to install a `.plateupmod` file directly without a Repository.

`Remove` is used to uninstall an existing package.

### Search

Your `Search` menu is where you can download new packages from your Repositories.

`Refresh` is used to update the package list ( Repositories may change their packages )

`Install` is used to download and install packages.

`Local Down` is used to download a package locally into a `.plateupmod` file.

### Settings

Your `Settings` menu contains values which PPM can pull from for various uses.

`Debug` generates a `Debug.log` file on your Desktop to assist developers.

`Update` checks for PPM updates, and downloads the update! ( PPM will close once the update is downloaded, and install on re-launch )

## Credits

Semver is licensed under the MIT License, see [LICENSE.txt](https://github.com/maxhauser/semver/blob/master/License.txt) for more information.
