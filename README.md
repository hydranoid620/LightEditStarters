# LightEditStarters
The only way to start light edit mode with a JetBrains IDE is through somehting like `<IDE launcher>.exe -e <file name>`. As far as I know, 
you can't tell Windows to start a program this way *without* touching the registry. 

I made these (almost) one liner programs as wrappers for that light edit launch command. **This code will probably not work out of the box.**
I use paths that are relevant to my Windows install, specifically the path to the launchers. Aside from that, to use these wrappers, simply choose to open
your file with the appropriate editor's light edit mode wrapper. 

For example, I might right click a `.tsx` file, select "open with", then select wherever I have `WebStormStarter.exe`.
