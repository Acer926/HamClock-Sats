# HamClock-Sats
HamClock on Windows , Satellite TLE updater.  
HamClock eSat Updater

It’s not pretty, but it’s been working on my install of HamClock.

Small Windows app that automatically updates the HamClock esats.txt file every 2.5 hours.

Designed for HamClock installations running under WSL (Windows Subsystem for Linux).

The program pulls satellite data from the AMSAT nasabare.txt list and rebuilds the esats.txt file used by HamClock.

#What It Does

Updates esats.txt every 2.5 hours (HamClock expires TLE data at 3 hours)

Lets you choose up to 52 satellites

Automatically adds the Moon as satellite #53

Supports any number of satellites up to 52 (plus Moon)

Satellite names must match entries from the AMSAT nasabare.txt file exactly (case-insensitive, but spelling must match).

##Requirements

Windows 10 or 11

.NET Framework 4.7.2

HamClock running under WSL

Access to your HamClock folder, for example:

#Setup

Extract all files into a folder.

Run the program.

Enter the full path to your HamClock folder in the textbox.

Edit eSat-list.txt in the same folder as the EXE to choose your satellites (or run with the default list).

Minimize the program.

When minimized, the icon appears in the taskbar’s Show hidden icons area (the small arrow near the clock).

Double-click the icon to reopen.

Right-click the icon to exit.

#Notes

eSat-list.txt can contain up to 52 satellite names.

The Moon is automatically added as the 53rd entry.

If you only want 10 satellites + Moon, that works fine.

The program overwrites esats.txt each time it updates.

Default Satellite List (Example)

The included eSat-list.txt contains the following satellites plus Moon:

NO-44
RS-44
SO-50
AO-07
AO-27
AO-73
AO-95
AO-123
CO-55
CO-65
FO-29
GO-32
HADES-ICM (SO-125)
ISAT
ISS
JO-97
LILACSAT-2
LO-19
LO-74
PO-101
QO-100
ROBUSTA-3A
RS22
RS30
RS38S
SONATE-2
Sparrow
TechnoSat
CSS (TIANHE-1)
UmKA 1 (RS40S)
UO-11
CO-57
CO-58
CO-66
SRMSAT
ZACUBE-1
Delfi-N3xt
GOMX-1
DTUSAT-2
EO-80
Horyu-4
Lapan A3
CAS-2T
AO-91
S-Net D
S-Net B
S-Net A
S-Net C
Ten-Koh
MinXSS-2
SNUSat 2
SnugLite
Moon
