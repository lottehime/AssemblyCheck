-------
AssemblyCheck
-------

Simple drop in file to print assemblies and info + check security critical and output to console and or log file.

-------
Usage
-------

- Throw this into your project folder and add or replace the existing in your project.
- Prepare an elevated console and point it to `"%SCE_PSM_UNITY%\tools\PsmDevice\"`.
- Plug in target device.
- Run command `PsmDeviceForUnity.exe -list_devices` to obtain the targets GUID.
- Prepare but do not run command `PsmDeviceForUnity.exe -get_log [GUID]` replacing `[GUID]` with target GUID from above.
- You can optionally (recommended) log to file via appending something like ` >> C:\log.txt` to the end of the command.
- Build and run the project as development build with script debugging (optional?).
- Once project is installed and beginning to run (splash screen), run the command you prepared above.
- Once the project has begun to run a level, you should be safe to close it and `^C` in console to end.

-------
References
-------
Because the logging for target is not exactly advertised well:
- [PSM Docs](https://psm.playstation.net/static/general/all/unity_for_psm/en/Documentation/Manual/PSMPsmDevice.html)

-------
Tested Build Info
-------
- Version: 4.3.4
- Runtime Version: 4.3.4.2
- Build: 4.3.4f1 (8129b852afe7

-------
Help
-------

- [Yifan](https://twitter.com/yifanlu) for being the hammer when all he had was my slow ass for a nail.
