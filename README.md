# Wpf Snippets
[![Release](https://github.com/niklashempel/WpfSnippets/actions/workflows/release-pipeline.yml/badge.svg?branch=main)](https://github.com/niklashempel/WpfSnippets/actions/workflows/release-pipeline.yml)  [![Marketplace](https://vsmarketplacebadge.apphb.com/version/niklashempel.WpfSnippets.svg)](https://marketplace.visualstudio.com/items?itemName=niklashempel.WpfSnippets)<br/>

WPF Snippets is an extensions for Visual Studio 2022. It provides snippets that may be used in a WPF application.

<h2>Links</h2>
Download: <a title="Visual Studio Marketplace" href="https://marketplace.visualstudio.com/items?itemName=niklashempel.WpfSnippets" target="_blank">Visual Studio Marketplace</a> <br />
Code, Issues: <a title="GitHub" href="https://github.com/niklashempel/WpfSnippets" target="_blank">GitHub</a> <br />

<h2>Features</h2>

The following snippets are added:

- `base`: BaseViewModel class with implemented INotifyPropertyChanged interface
![base snippet](https://github.com/niklashempel/WpfSnippets/blob/main/images/base.png)
- `propn`: Property with a backing field. When the property setter gets called, the OnPropertyChanged method is called too.
![propn snippet](https://github.com/niklashempel/WpfSnippets/blob/main/images/propn.png)
- `relay`: RelayCommand and AsyncCommand classes for synchronous/asynchronous command calls
- `cmd`: RelayCommand that calls a method when invoked. No extra instantiation needed within the constrcutor.
![cmd snippet](https://github.com/niklashempel/WpfSnippets/blob/main/images/cmd.png)
- `cmdo`: RelayCommand where a parameter can be passed. In XAML this is done via "CommandParameter=xxx"
![cmdo snippet](https://github.com/niklashempel/WpfSnippets/blob/main/images/cmdo.png)
- `acmd`: Async command that calls an async method when invoked.
![acmd snippet](https://github.com/niklashempel/WpfSnippets/blob/main/images/acmd.png)
- `acmdo`: Async command where a parameter can be passed.
![acmdo snippet](https://github.com/niklashempel/WpfSnippets/blob/main/images/acmdo.png)
