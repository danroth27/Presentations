# Blazor overview

## Setup

- Start .NET Podcasts backend
- Screen resolution to 1920x1080
- Close all chat, email, todo
- Share with audio and video optimizations
- Start android emulator

## Intro 

Hi everyone! I'm Daniel Roth, a Principal Product Manager on the ASP.NET team at Microsoft. I'm thrilled to be with you all today to talk about one of my favorite topics: Building modern web UI with .NET & Blazor.

## .NET: Build anything

.NET is your single, unified, developer platform for building anything. No matter what kind of app your trying to build (mobile, desktop, web, games, AI), .NET provides you with the languages, frameworks, and tools you need to get building and be productive.

## .NET adoption

There are now over 5.6M monthly .NET users and that number keeps growing. The latest version of .NET, .NET 6, is also the fastest adopted .NET version ever. .NET 6 is being adopted almost 2x faster then the previous version.

## What is Blazor?

.NET has always had great support for building web apps. However, for a long time if you wanted to write code that ran client-side in a web browser, you had to use JavaScript. JavaScript has come a long way from its humble beginnings, but having to deal with two different developer ecosystems (language, frameworks, tools, etc) adds complexity and cost.

Blazor is a modern client web UI framework based on .NET & C#. With Blazor you can build rich interactive web UI based purely on open web standards that runs on any device without having to write any JavaScript. Blazor enables you to leverage your existing .NET skills, tools, and code to build rich, interactive web apps. It's full stack web development with .NET!

## Blazor components

Blazor apps are made up of components. Blazor components encapsule pieces of web UI including what to render, any state that's needed, and any UI event handling logic. Blazor components make it easy and fast to build up a web UI from reusable part. In a Blazor app the framework keeps track of what each component renders and then calculates exactly the UI deltas that need to be applied to the browser DOM so that UI updates are fast and efficient.

## Part of  ASP.NET Core 

Blazor is part of ASP.NET Core, our modern web framework for .NET. ASP.NET Core comes with everything you need to build beautiful web UI and powerful backend services.

The addition of Blazor to ASP.NET Core expands the reach of your .NET web apps to the client and enables full-stack web development with .NET.

There's no need to rewrite your existing ASP.NET Core apps to use Blazor. Blazor integrates with existing ASP.NET Core apps. You can add Blazor components to your pages and views to light up rich interactivity while preserving existing functionality.

## Supported in .NET 6 LTS

Blazor ships as part of the .NET platform and is included in .NET 6, our most recent Long Term Support (LTS) release. .NET LTS releases have a 3 year support lifecycle.

.NET 6 LTS is also loaded with new Blazor features and improvements:

> Go through the list

We'll take a look at some of these features later in the session.

## Component vendors

Blazor has a vibrant ecosystem and open source community. Blazor component libraries are available from all the major control vendors. They offer everything you need to build beautiful UI, from grids to charts to tab views and so on.

## Open source

Blazor also has an active open source community and ecosystem. There are free open source projects for everything you need including component libraries, JS interop libraries, test frameworks, and more. You can find many Blazor open source projects listed on the Awesome Blazor repo at aka.ms/awesomeblazor.

## Microsoft Fluent UI components

Microsoft provides Blazor Fluent UI components. This library includes over 40 fully accessible components, that support light, dark, and high contrast, and are built to integrate with Microsoft products including Windows 11. You can check them out at aka.ms/blazor-fluent-ui.

## Blazor customers

Blazor is one of the fastest growing parts of the .NET platform and is used by companies big and small to handle their web UI needs.

- **GE Digital**: GE Digital is an industry leader in airline systems. Their FlightPulse app puts sensor data and analytics into the hands of thousands of pilots to help them improve safety and efficiency. The backend configuration of what data the pilots see is all done using Blazor
- **Dynamics 365 Connected Store**: Microsoft uses Blazor too! Dynamics 365 Connected Spaces is a new offering to help optimize in-store operations with real-time observational data. The in-store setup and configuration is all done using Blazor.

## How it works

Blazor web apps work in one of two ways.

- **Blazor Server**: The first way we call Blazor Server. In a Blazor Server app, your web UI components run on the server as part of an ASP.NET Core app. All of the UI interactions and updates are handled using a real-time WebSocket connection with the browser. Blazor Server apps are fast to startup and simple to implement, because all of your code stays on the server.
- **Blazor WebAssembly**: The second way Blazor apps work we call Blazor WebAssembly. Blazor WebAssembly enables running .NET code directly in the browser using a WebAssembly based .NET runtime that is deployed with your app.

## Server vs WebAssembly

Which Blazor hosting model you chose for your web app will depend on its requirements.

Blazor Server is a great way to start. Your app runs from the server, so you have full access to server capabilities. Blazor Server also requires very little from the client, so it works well with thin clients and on lower-powered devices. Blazor Server does, however, require a persistent connection to function and requires server resources to handle each connected user. Latency for UI interactions is also higher because they are handled over the network.

Blazor WebAssembly apps are true client browser apps. They run fully on the client and can be deployed as simple static websites. Once downloaded, a Blazor WebAssembly app can function completely offline. We include built-in support for building Progressive Web Apps (PWAs) with Blazor WebAssembly. Blazor WebAssembly apps, however, are larger to download and they generally have slower runtime performance, although that can be mitigated with ahead of time (AOT) compilation support, which we'll look at in a bit.

## Shared component model

Regardless of how you decide to host your Blazor app, the way your write your web UI components doesn't change. The same Blazor components can run in both Blazor Server and Blazor WebAssembly apps. Switching between the two hosting models is reasonably straightforward.

## Get started

> 10:00

Getting started with Blazor is easy. Just go to https://blazor.net and download the latest .NET Core SDK. You then develop your Blazor app on your preferred platform using Visual Studio, Visual Studio for Mac, or Visual Studio Code.

## DEMO: Get started with Blazor and Hot Reload

Let me show you what a building Blazor web app looks like.

If you're trying out Blazor for the first time, you can get started by going to http://blazor.net and click the get started button. This tutorial will walk you through setting up your machine and building your first Blazor app. And then at the end there are links to videos and learning paths that you can follow.

Let's create a our Blazor using Visual Studio. I'm going to create a Blazor Server app for this demo, but you could just as easily create a Blazor WebAssembly app.

- Create a Blazor Server app
- Run it with debugging
- Show home page
- Talk to routing, PageTitle, SurveyPrompt, component parameters
- Show Counter, event handling, hit break point in Counter
- Add Counter to home page, hot reload
- Show data binding an input
- Show the network trace
- Show weather table
- Talk to DI, C# control flow, lifecycle events
- QuickGrid:

It would be nice if it were a proper grid that we could filter, sort, and page. There are wonderful and feature rich Blazor grid components available from all the major control vendors. But for something simple like this we can use the new experimental QuickGrid component. QuickGrid is a reference implementation of a data grid component for Blazor that is done purely in C# and is designed for fast rendering. QuickGrid isn't as fully featured as the many of the commercial Blazor grid components that are available, so you'll definitely want to check those out, but for a "quick" job like this it can get the job done.

- Add the package
- Update FetchData to use `QuickGrid`, start simple

```razor
<QuickGrid Items="Forecasts">
    <PropertyColumn Property="w => w.Date" />
    <PropertyColumn Property="w => w.TemperatureC" />
    <PropertyColumn Property="w => w.TemperatureF" />
    <PropertyColumn Property="w => w.Summary" />
</QuickGrid>
```

```csharp
public IQueryable<WeatherForecast>? Forecasts => forecasts!.AsQueryable();
```

- Add more Grid functionality

```razor
<QuickGrid Items="Forecasts" ResizableColumns="true">
    <PropertyColumn Property="w => w.Date" Format="MMM d" Sortable="true" />
    <PropertyColumn Title="Temp. (C)" Property="w => w.TemperatureC" Sortable="true" />
    <PropertyColumn Title="Temp. (F)" Property="w => w.TemperatureF" />
    <PropertyColumn Property="w => w.Summary">
        <ColumnOptions>
            <input type="search" autofocus placeholder="Summary search..." @bind="summarySearch" @bind:event="oninput" />
        </ColumnOptions>
    </PropertyColumn>
</QuickGrid>
```

```csharp
string summarySearch = string.Empty;

IQueryable<WeatherForecast>? Forecasts => 
    forecasts?.Where(w => w.Summary!.Contains(summarySearch)).AsQueryable();
```

- Show `QuickGrid` samples site: https://aka.ms/blazor/quickgrid

- Create a ASP.NET Core Blazor WebAssembly app
- Go through the solution structure, emphasize shared code
- Emphasize the component code is the same
- Debug Counter it in Visual Studio
- Step through from FetchData to the API controller
- Show the network trace

## .NET WebAssembly build tools

.NET 6 includes new .NET WebAssembly build tools for working with your Blazor WebAssembly apps. These tools can be installed as an optional .NET SDK workload, or using Visual Studio.

- **AOT compilation**: With these build tools you can now ahead-of-time compile your Blazor WebAssembly apps to WebAssembly for much better runtime performance.
- **Runtime relinking**: You can also relink the .NET WebAssembly runtime when publishing to remove unused features, like debugging or globalization features.
- **Native dependencies**: You can also link in native dependencies into the runtime to enable new scenarios.

## Blazor WebAssembly trimming

In addition to runtime relinking, Blazor WebAssembly apps in .NET 6 are much smaller thanks to various improvements to the .NET IL trimmer. In .NET 5, the smallest Blazor WebAssembly you could make was about 1.7MB when published. With .NET 6, a min Blazor WebAssembly app is only 1.1MB, about a 40% reduction.

## DEMO: .NET WebAssembly build tools

### Runtime relinking

- Run satellite simulator
- Ramp up satellites to 10k until the frame rate drops below 60fps
- This is just a Debug build; Release build is faster
- Show dotnet.wasm size in debug
- Publish the app with runtime relinking
- Ramp up to 20k
- Show smaller dotnet.wasm

### AOT

- We can go faster! Enable AOT, and run published app
- Ramp up to 100k

### Native dependencies

- Open BlazorWebAssemblyDemos with SkiaSharp code
- Highlight C & C++ usage
- SkiaSharp
- Trains.NET: https://wengier.com/Trains.NET/

## Blazor beyond the web

So, Blazor gives you everything you need to build rich interaction web UI experience. But what if you need more than what a web app is capable of? What if you need full native app capabilities?

Earlier this year we expanded Blazor beyond the web to support situations where the web platform by itself just isn't enough. We added support for using Blazor to build native mobile and desktop apps using a new component hosting model that we call Blazor Hybrid.

## What is Blazor Hybrid?

What is Blazor Hybrid? In a Blazor Hybrid app, your Blazor components and .NET code are packaged as part of the app and run natively on the device. WebAssembly isn't involved. Your Blazor components run as part of the app and then render to an embedded web view control. Blazor Hybrid apps enable you to share a common web UI and app functionality across mobile, desktop, and web, while also enabling deeper integration with the underlying native platform.

## Blazor Hybrid with .NET MAUI

The best way to create a Blazor Hybrid app is with .NET MAUI. .NET MAUI has Blazor Hybrid support built into the framework. .NET MAUI supports embedding Blazor web UI components directly into the app. By using .NET MAUI and Blazor together you can reuse one set of web UI components across mobile, desktop, and web. .NET MAUI Blazor apps can also take advantage of .NET MAUI features, like using native UI elements and directly accessing native device functionality.

## Demo: .NET MAUI Blazor

Let's take a look at building a Blazor Hybrid app using .NET MAUI.

### Create a new .NET MAUI Blazor app

We can create a .NET MAUI Blazor app using the provided template. This template creates a normal .NET MAUI project setup to also use Blazor components.

This single project is setup to target Windows, macOS, iOS, and Android. Let's start it running on Windows.

While that's building, we can take a look at the app.

- The main page for this app is in *MainPage.xaml*. In .NET MAUI you use XAML to author cross platform native UI. On Windows, MAUI uses WinUI3, on Android you get Android controls, and so on.
- The only MAUI control this app is using is a `BlazorWebView`. A `BlazorWebView` runs your Blazor components directly in the app and renders them to an embedded web view over a local interop channel. This `BlazorWebView` is setup to render the `Main` component.
- The `Main` component is defined in *Main.razor*. It sets up the Blazor `Router`, which enable navigation to the various pages in the *Pages* directory: `Index`, `Counter`, and `FetchData`.

If we go to the running app, we can see all those pages now. Our Blazor components are being rendered in a native Windows app.

We can also run the app on Android. And now we can see the same functionality running as a native Android. I don't have a Mac setup, but the same app also works on iOS and macOS.

### Native UI

Since this is a .NET MAUI app, we can use native UI alongside our Blazor based UI.

Let's switch this page to be a native `TabbedPage` (XAML & code behind).

We'll then wrap our BlazorWebView in a `ContentPage`.

To have multiple tabs we can then replicate the `ContentPage` for each of our Blazor pages. We'll set the type for each *BlazorWebView*. Let's also change the background to white.

OK, the tabs aren't showing up yet, because they don't have a title. Let's add that. XAML hot reload shows the changes almost immediately. We can also add some padding on the content pages. Looks good! 

We can also see the same result on Android.

> Run on Android

```xml
<?xml version="1.0" encoding="utf-8" ?>
<TabbedPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:b="clr-namespace:Microsoft.AspNetCore.Components.WebView.Maui;assembly=Microsoft.AspNetCore.Components.WebView.Maui"
             xmlns:local="clr-namespace:MauiApp1"
             xmlns:pages="clr-namespace:MauiApp1.Pages"
             x:Class="MauiApp1.MainPage"
             BackgroundColor="White">

    <ContentPage Title="Home" Padding="10">
        <b:BlazorWebView HostPage="wwwroot/index.html">
            <b:BlazorWebView.RootComponents>
                <b:RootComponent Selector="#app" ComponentType="{x:Type pages:Index}" />
            </b:BlazorWebView.RootComponents>
        </b:BlazorWebView>
    </ContentPage>

    <ContentPage Title="Counter" Padding="10">
        <b:BlazorWebView HostPage="wwwroot/index.html">
            <b:BlazorWebView.RootComponents>
                <b:RootComponent Selector="#app" ComponentType="{x:Type pages:Counter}" />
            </b:BlazorWebView.RootComponents>
        </b:BlazorWebView>
    </ContentPage>

    <ContentPage Title="Weather" Padding="10">
        <b:BlazorWebView HostPage="wwwroot/index.html">
            <b:BlazorWebView.RootComponents>
                <b:RootComponent Selector="#app" ComponentType="{x:Type pages:FetchData}" />
            </b:BlazorWebView.RootComponents>
        </b:BlazorWebView>
    </ContentPage>
    
</TabbedPage>
```

### Native platform functionality

We can do more than just native UI. Because this is a native client app, we can do things that wouldn't otherwise be possible or would be more difficult with just the web. 

To show you what I mean, let's add a button that checks the network status. We can do that using MAUI Essentials. MAUI Essentials is a set of .NET APIs for accessing native platform functionality in a cross platform way that ships.

```razor
<button class="btn btn-primary" @onclick="CheckInternet">Check internet</button>

@code {
    public async void CheckInternet()
    {
        var hasInternet = Connectivity.NetworkAccess == NetworkAccess.Internet;
        var type = 
            Connectivity.ConnectionProfiles?.FirstOrDefault() ?? 
            ConnectionProfile.Unknown;

        await MauiApp1.App.Current.MainPage.DisplayAlert(
            title: "Status", 
            message: $"Has internet: {hasInternet}, type: {type}", 
            cancel: "OK");
    }
}
```

If we tap the button we get a native alert with the network status. If we turn on airplane mode we can see the status update. The same functionality works on Windows.

- Update Index.razor to launch Notepad and use as editor

```razor
@using System.IO
...
<h3>@message</h3>
<button @onclick="GetMessage">Edit</button>

@code {
    string message = "Hello!";

    void GetMessage() {
        var file = Path.GetTempFileName();
        File.WriteAllText(file, "Enter message here");
        var p = System.Diagnostics.Process.Start("notepad", file);
        p.WaitForExit();
        message = File.ReadAllText(file);
    }
}
```

### .NET Podcasts app

Here's a more realistic example of an app that share Blazor UI components across mobile, desktop, and web.

- Show running on the web
- Add .NET MAUI Blazor project
- Show app running on desktop and mobile
- Open dev tools to show that it's all web UI
- Show listen together
- Show native audio playback

## Modernize with Blazor Hybrid

The Blazor Hybrid pattern isn't limited to .NET MAUI. You can use Blazor components anywhere you can run .NET code and you have a web view to render them to. For example, you can use Blazor Hybrid with existing Windows desktop apps too. This can be a great way to modernize the UI of existing apps. 

> Click

The UI for this legacy point of sale app for dry cleaning establishments was completely redone using Blazor enabling the app to be available on the web while reusing existing .NET business logic.

In addition to supporting Blazor with .NET MAUI, we also have `BlazorWebView` controls for WPF and Windows Forms via NuGet. This is a great way to modernize existing apps with a web based UI that can be reused with .NET MAUI and the web in the future. 

## Demo: Blazor Hybrid with WPF and Windows Forms

Here's a sample of a WPF app hosting Blazor components. It uses a `BlazorWebView` just like we saw with .NET MAUI, but now hosted in WPF.

And here's a Windows Forms app hosting Blazor components.

Using the Blazor Hybrid model, you can add as little or as much Blazor as you want even to existing Windows desktop apps.

## From web to native

So with .NET you have access to a full spectrum of capabilities for building apps to take advantage of both the reach of the web and the power of native client apps. Blazor and .NET MAUI together give you the reach of the web combined with the power of native apps.

## Blazor in .NET 7

There's lots more to come for Blazor in the upcoming .NET 7 release. 

## Demo: Blazor and JavaScript together

- Show Blazor custom elements
- Show new JS interop
- https://pavelsavara.github.io/blazor-wasm-hands-pose/ 

## Schedule

- .NET 6 LTS, .NET MAUI, and Blazor Hybrid support were all released this past year
- .NET 7 Release Candidate 1 is already available, and .NET 7 will ship a stable release in Nov of this year
- .NET ships a major release every November, even numbered LTS releases

## Conclusion

I hope you enjoyed learning about Blazor! I'm happy to stick around and answer any questions you might have.