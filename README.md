# LightEditStarters
The only way to start light edit mode with a JetBrains IDE is through somehting like `<IDE launcher>.exe -e <file name>`. As far as I know, 
you can't tell Windows to start a program this way *without* touching the registry. 

I made these (almost) one liner programs as wrappers for that light edit launch command. 


# Building and Configuring
I don't do anything special, really. I chose to target `net5.0` so you'll need that to compile.

In the directory where you compile or publish to, there is a `appsettings.json` file. In there, you will need to supply a path (remember to escape the back slashes) to where the relevant IDE is. For example,
if I have the CLion executable in `C:\CLion\clion64.exe`, my `appsettings.json` file would look like this
```
{
  "ProcessStartInfo": {
    "FileName": "C:\\CLion\\clion64.exe"
  }
}

```
If you usee Toolbox to auto update your IDEs, you can also specify the shortcut it makes to your IDEs here.


# Usage
Set your desired file types to open with the appropraite wrapper. Thats it.

For example, I might right click a `.tsx` file, select "open with", then select wherever I have `WebStormStarter.exe`.
