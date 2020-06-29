# Blazor

## Setup

- Use lapel mic
- Open web browser: `msedge.exe --remote-debugging-port=9222 https://blazor.net`
- Set browser preferred language to English, with Spanish as an option
- Cleanup desktop
- Close unnecessary apps
- Delete any previous default Blazor app projects
- Start Visual Studio
- Open [CarChecker](https://aka.ms/blazor-carchecker) solution in separate VS instance
- Start CarChecker server
- Run CarChecker app, logout, login, close app
- Uninstall sample Blazor PWAs
- Run ZoomIt
- Collapse all the solution folders except for *sample/MyApplication/* and set **MyApplication.Windows** as the startup project
- Open *sample/MyApplication/Main.razor* in the editor.
- Remove the `BlazorWebView` component from *Main.razor*
- Start the **CarChecker.Server** project in the *sample/CarChecker.Shared* folder and have it running.
- https://streamyard.com/bvt735c9f2

## What is Blazor?

To explain want Blazor is all about, let's suppose you want to build a modern sophisticated web app. You're going to need your app to run in regular desktop browsers and mobile browsers with a nice responsive design. You're app is going to need a rich interactive UI with grids, dialogs, wizards, forms, validation, and of course you've got to worry about authentication, localization, and so on. Maybe your app also needs to be installable and be able to function even when it's offline.

A few years, ago the only way to build such an app would be to use a JavaScript framework and to write your app in JavaScript or a language that compiles to Javascript. But thanks to modern web standards, that's no longer the case. Blazor is a web UI framework for building single-page apps using .NET and C# instead of JavaScript. With Blazor you can build your entire app with .NET. You can get the productivity of C#, Visual Studio, and a consistent and stable ecosystem to build rich modern web UI along with a high performance .NET backend. Blazor is open source, cross-platform, and runs in any modern web browser.

## How it works

How is this possible? Blazor apps can work in one of two ways.

- **Blazor Server**: The first way we call Blazor Server. In a Blazor Server app, your web UI components run on the server using .NET Core. All of the UI interactions and updates are then handled using a real-time WebSocket connection with the browser. Blazor Server apps are fast to startup and simple to implement, because all of your code stays on the server. Support for Blazor Server apps shipped last year with the .NET Core 3.1 LTS release.
- **Blazor WebAssembly**: The second way Blazor apps work we call Blazor WebAssembly. Blazor WebAssembly enables running .NET code directly in the browser using a WebAssembly based .NET runtime that is deployed with your app. When paired with .NET Core, Blazor WebAssembly enables full-stack web development with .NET. Blazor WebAssembly apps are true client-side web apps. Because Blazor WebAssembly apps run completely client-side on the user's device, they can be deployed as simple static sites and they can support offline scenarios.

## Blazor WebAssembly released!

Earlier this month we were thrilled to announce at the Microsoft BUILD conference that Blazor WebAssembly is now official released and supported for production use. Blazor WebAssembly is now included with the latest .NET Core SDK (3.1.300) and also ships with Visual Studio 2019 16.6 and Visual Studio for Mac 8.6.

## Blazor WebAssembly features

This release of Blazor WebAssembly comes packed with features!:

- **.NET Standard 2.1**: Blazor WebAssembly supports .NET Standard 2.1, so you can reuse existing libraries on both the client and the server
- **ASP.NET Core hosted / standalone**: You can host your app with ASP.NET Core for a full-stack experience, or deploy your app as a standalone static site.
- **Authentication**: Blazor WebAssembly supports authentication using ASP.NET Core Identity & IdentityServer, Azure AD, Azure AD B2C, or an OpenID Connect provider of your choice.
- **Progressive Web Apps**: You can use Blazor WebAssembly to create Progressive Web Apps (PWAs) that support offline execution and native OS integration.
- **Debugging**: You can debug your code running in the browser using the browser dev tools or directly from Visual Studio.
- **IL trimming**: When you publish your app, unused code gets automatically trimmed to significantly reduce the app download size.
- **Precompressed**: We also aggressively precompress the published app to reduce its size even further.
- **Configuration**: You can also configure your app...
- **Localization**: ...and localize it using the same abstractions used in ASP.NET Core.

## Get started

Blazor WebAssembly is super easy to get started with. Just go to https://blazor.net and download the latest .NET Core SDK (3.1.300 or later). You can then develop your Blazor WebAssembly app using Visual Studio, Visual Studio for Mac, or Visual Studio Code.

## DEMO: Blazor WebAssembly in action

### Getting started
- New project options
- ASP.NET Core hosted
- Debug in browser & VS
- Authentication
- Full stack development and debugging
- Installable PWA

### A real world app

- Switch to CarChecker as a real world app
- JS interop
- Forms and validation
- File upload
- Offline 
- Localization

## Blazor in .NET 5

- Both Blazor Server & Blazor WebAssembly
- New features

## Blazor Hybrid & Native

Even early on in the Blazor project we know that we wanted Blazor to be used for more than just web apps. While PWAs are great, the app is still running inside of a browser with all its limitations. What if you wanted to build a native app that runs natively on the device, but still leverage web technologies for your UI? We call this pattern a Blazor Hybrid app, hybrid because it uses a mix of native and web technologies in the same app. Hybrid apps enable you to reuse your existing web UI in a native app. We've already done some experiments with Blazor Hybrid apps, like using Blazor & .NET to build Electron apps.

But Blazor can do more than just web UI. The Blazor component model is very flexible and is decoupled from how the UI is actually rendered. Blazor components typically render normal HTML, but they don't have to. The renderer can be replaced to render to whatever you want, even native controls. Blazor Native apps let you reuse the familiar Blazor programming model to write fully native apps with native UI.

## Mobile Blazor Bindings

The Mobile Blazor Bindings experimental project is a collaboration between the Xamarin and Blazor teams to experiment with using Blazor to build cross-platform native apps. These apps run natively on the machine - no WebAssembly involved - and render native UI using the same technology used for Xamarin Forms (and in the future .NET MAUI apps). As a web developer, you get full access to the device's capabilities through .NET and C# and the familiar Blazor programming model.

## DEMO: Mobile Blazor Bindings & BlazorWebView

### Mobile Blazor Bindings

Here's a simple Mobile Blazor Bindings desktop app where the UI is defined using the Blazor programming model in a .razor file.

> Show the Main.razor file with the counter UI.

Instead of using HTML, each of these components in the Razor file is a native component. If we run the app we get a simple counter built using native controls.

> Run the Blazor native desktop app.

![image](https://user-images.githubusercontent.com/1874516/80657385-4f369400-8a38-11ea-9912-95263d8af906.png)

### Hybrid apps

Instead of writing all of our UI from scratch using native components, we might want to leverage some existing UI from our web apps and build a hybrid app. But we can't just start typing HTML alongside our native UI. First we need a web view to render the HTML.

> Add a `BlazorWebView` with some HTML to the .razor page

```html
<BlazorWebView>
  <h2>Hi! I'm a BlazorWebView!</h2>
  <p>This is <em>so cool!</em></p>
</BlazorWebView>
```

But this isn't just a web view - it's a *Blazor* web view. So we can use it with Razor syntax too. Let's create another counter built with web UI using Razor syntax and reference the same state from the native counter.

> Update the `BlazorWebView` to contain a full counter component implementation synchronized with the native one. 

```razor
<BlazorWebView>
    <h1>The current count is: @CounterState.CurrentCount</h1>
    <button @onclick="CounterState.IncrementCount">Count</button>
</BlazorWebView>
```

> Close the running app and rerun it.

Notice that the native UI and the web UI stay in sync because they use the same state. Also note that this Blazor code isn't running on WebAssembly. It's running on the same native .NET runtime that used to power the rest of the Maui app.

Now that we can use Blazor web UI in our Maui app, we can reuse components from our Blazor web apps. This app has the entire UI for the default Blazor project template included in it.

> Expand the **MyApplication** solution in the *sample/MyApplication* solution folder and show the template code in the *WebUI/Pages* folder.

So we can embed that entire UI in our Maui app.

> Replace the `BlazorWebView` with the following updated one:

```razor
<BlazorWebView ContentRoot="WebUI/wwwroot" VerticalOptions="LayoutOptions.FillAndExpand">
  <MyApplication.WebUI.App />
</BlazorWebView>
```

> Close and rerun the app.

![image](https://user-images.githubusercontent.com/1874516/80657426-64abbe00-8a38-11ea-856e-d4f39db5947a.png)

### CarChecker as a Native app

Using Mobile Blazor Bindings, you can build an entire hybrid app that leverages your existing Blazor web UI components. You can take an existing web UI and turn it into a native app. In fact, here we have the entire CarChecker app that we previously built with Blazor WebAssembly setup to run as Maui app. 

> Set the **CarChecker.Maui** project in the *sample* folder as the startup project and run it.

> Wait for the app status bar to indicate that the app has updated its local data store. If the update fails, then check that you started the *sample/CarCheckerShared/CarChecker.Server* project as specified in the setup steps.

> Search for a car using a license plate of your choice.

### Native integration

> 4:15

Because this app is running natively on my machine it can integrate with native capabilities. For example, we added an **Open Report** button at the bottom to export a report for this car and then open it in Notepad. This is something you couldn't do from within a browser sandbox, but in a Maui app your Blazor components are running as regular desktop code so they can do anything.

> Click on **Open Report** in the bottom left-hand corner

> Show the Notepad instance that pops up with the vehicle report

![image](https://user-images.githubusercontent.com/1874516/80656944-39749f00-8a37-11ea-83d0-c6db1fa276dc.png)

By combining Blazor with Maui you can get productive building cross-platform UI regardless of your development background. If you're a web developer, you can use the familiar Blazor programming model to build both fully native and hybrid apps that leverage your existing skills and web UI components.

> 5:00