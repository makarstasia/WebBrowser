# __WebBrowser__

19.03.2021
---
Makarshina Anastasia

Applied math

1 course

group 09-021

---
## Hotkeys

Hotkeys | Function
------------ | -------------
Enter	| Page search
F5	| Add a new window
F10 | Add page to saved
## System requirements

- You need [VC++ 2015 Runtime](https://www.microsoft.com/en-in/download/details.aspx?id=48145) 32-bit and 64-bit versions

- You need .NET Framework 4.6.

- You need to install the version of VC++ Runtime that CEFSharp needs. Since we are using CefSharp 79, according to [this](https://github.com/cefsharp/CefSharp/#release-branches) we need the above versions

## Code

- SharpBrowser uses CefSharp 79 and is built on NET Framework 4.6
- SharpBrowser supports AnyCPU as well as x86/x64 specific builds
- `MainForm.cs` - main web browser UI and related functionality
- `bin` - Binaries are included in the `bin` folder due to the complex CefSharp setup required. Don't empty this folder.

##Provide opportunities

- [x] return to the previous search page;
- [x] go to page forward;
- [x] stop loading the page; `
- [x] refreshing the page content;
- [x] saving the page to bookmarks;
- [x] saving the history of page views for the last week;
- [x] removing a page from bookmarks;
- [x] clearing the history of page views;
- [ ] save the open page to disk.
