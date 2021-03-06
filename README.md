A Visual Studio 2012/2013 extension providing easy access to project debug command line arguments, via a dockable re-sizeable textbox.

## Download ##
[DockableCLArgs.vsix](https://github.com/MatthewCox/DockableCLArgs/raw/master/DockableCLArgs.vsix)

## Features ##
- history & saved command line args, via right click menu
- matches the light/dark theme settings of visual studio
- syntax highlighting

<p align="center"><img src="http://i.imgur.com/PLRu8ox.png" /></p>
- a range of settings; history depth, font family and size, syntax highlighting colours. All visual settings update live as you adjust them, and revert if you cancel out of the options window.

<p align="center"><img src="http://i.imgur.com/Br7i88y.png" /></p>
- supports C++, C#, and VB projects (VB support is untested, let me know if there are problems)

## License ##
The project as a whole is under the [MIT license](https://github.com/MatthewCox/DockableCLArgs/blob/master/LICENSE.txt), so do whatever you want with it as long as you include the license and an attribution to me.

The textbox control is [AvalonEdit](https://github.com/icsharpcode/SharpDevelop/wiki/AvalonEdit), which is under the [LGPL](http://www.gnu.org/copyleft/lesser.html).

The colour controls on the settings window are from the [WPF Color Picker Construction Kit](http://www.codeproject.com/Articles/131708/WPF-Color-Picker-Construction-Kit), and they're under the [Code Project Open License](http://www.codeproject.com/info/cpol10.aspx).

## Help with the project ##

If you'd like to help with the project, I've listed my future plans at the bottom of [CHANGELOG.txt](https://github.com/MatthewCox/DockableCLArgs/blob/master/CHANGELOG.txt) - other ideas are also welcome (and pull requests even more welcome!)

Pre-requisits for compiling the extension yourself:
- VS 2012/2013, Professional edition or higher
- VS [2012](http://www.microsoft.com/en-gb/download/details.aspx?id=30668)/[2013](http://www.microsoft.com/en-gb/download/details.aspx?id=40004) SDK
