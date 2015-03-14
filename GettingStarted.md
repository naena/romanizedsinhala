

# Introduction #

This guide will help you:
  * Setup Romanized Sinhala in your computer
  * Type English and Sinhala using a Word Processor
  * Send Emails in English and Sinhala
  * Browse web pages with Romanized Sinhala

# Requirements #
## Suriyakumara Font ##
Download the latest Smart Font for Sinhala:
[Suriyakumara Font](http://romanizedsinhala.googlecode.com/files/Suriyakumara.ttf)

## Romanized Sinhala Keyboard ##
Download the latest version of the keyboard for your operating system from:
http://code.google.com/p/romanizedsinhala/downloads/list?q=label:Type-Archive

  * For Windows XP, the file name will follow the pattern kbdssinh-**#.#**-xp.zip
  * For Windows Vista, the file name will follow the pattern kbdssinh-**#.#**-vista.zip

## WorldPad ##
Main artcile: http://www.sil.org/computing/catalog/show_software.asp?id=68

Download [WorldPad 2.8](http://scripts.sil.org/cms/scripts/render_download.php?site_id=nrsi&format=file&media_id=WorldPad_2_8_setup&filename=WorldPad_2_8_setup.msi)

## Mozilla Thunderbird ##

Download [Mozilla Thunderbird](http://www.mozillamessaging.com/en-US/thunderbird/)

The installer file for Windows will typically look like: thunderbird-3.0b3pre.en-US.win32.installer.exe

## Mozilla Firefox ##
[Mozilla Firefox 3.0](http://www.firefox.com/) or above

# Installation #
  * Install the Suriyakumara. This can be done by right clicking the font and clicking Install. You can also drag the font to Windows\Fonts folder.
  * Install the correct keyboard for your system. The Romanized Keyboard will show up under **Uzbek (Latin)** in Windows XP, and **Sinhala (Sri Lanka)** in Windows Vista.
  * Install WorldPad, Thunderbird and Firefox

# Configuration #

## Romanized Sinhala Keyboard ##
After the installation of the Keyboard, the new keyboard should be visible in the Language Bar automatically. If for some reason, the new keyboard is not displayed, you can set up the keyboard manually.

  * Setup keyboard shortcuts so that you can switch between languages quite easiliy: http://code.google.com/p/romanizedsinhala/wiki/LanguageBar

## WorldPad ##
  * Setup WorldPad according to the video: http://romanizedsinhala.googlecode.com/files/WorldPad%20Sinhala.avi
    * For Windows XP, the Language ID would be Uzbek (Latin).
    * For Windows Vista, the Language ID would be Sinhalese as seen in the video.

## Mozilla Thunderbird ##
### Relocating Profiles folder ###
This section is optional.

  * By default your emails are saved in %appdata%\Thunderbird\Profiles
  * You can relocate this to a folder in your Documents by modifying the profiles.ini file.
    * Start > Run or WinKey+R
    * Type:
```
%appdata%\Thunderbird
```
  * Locate the profiles.ini file
  * Change the IsRelative value to 0 and customize the Path:
```
[General]
StartWithLastProfile=1

[Profile0]
Name=default
IsRelative=0
Path=H:\Users\Mike\Documents\Applications\Thunderbird\2008
```

  * Upon the next launch of Thunderbird, the profile should be created inside your Documents folder.

## Mozilla Firefox ##

Firefox by default does not allow formation of ligatures for size under 20px. You will need to follow http://code.google.com/p/romanizedsinhala/wiki/FAQ#Why_are_my_letters_are_not_combined? in order to display the Sinhala letters properly

# Usage #

## WorldPad ##
WorldPad can be used for typing any offline document that contains a mixture of English and Sinhala. The writing system can be switched by a drop down menu. WorldPad automatically changes to the correct font and keyboard.