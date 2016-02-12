#data-view-projection

As enterprise apps grow in complexity, so does the relationships between the entities. When retrieving tons of data that have complex relationships and deep navigation properties, the process will take a toll n performance and UI responsiveness. This is where Crosslight View Projection comes in. With the View Projection technique, no matter how complex your object and relationship is, you can rest assured that data query is done very quickly and your data will display in seconds. 

![image](http://developer.intersoftsolutions.com/download/attachments/23699499/ViewProjection-SC-WT.png?version=1&modificationDate=1455270627096&api=v2)

This sample demonstrates how you can start using the View Projection feature in your Crosslight applications. To learn more about View Projection, see [Working with View Projection](http://developer.intersoftsolutions.com/display/crosslight/Working+with+View+Projection).

#Supported Platforms

This sample works on the following platforms:

* iOS: iOS 8 and above
* Android: 4.0.3 and above (optimized for 5.0 and above)

This project requires Crosslight 5.0.5000.526 or higher. For more information, see [Crosslight 5.0 Release Notes](http://developer.intersoftsolutions.com/display/crosslight/Crosslight+5.0+Release+Notes).

#Project Structure

* ViewProjectionSample.Android.Material: Crosslight Android.Material project, works on phones and tablets.
* ViewProjectionSample.Core: Shared Portable Class Library project running Profile78.
* ViewProjectionSample.DomainModels: Portable Class Library that contains shared domain models that can be used between client and server.
* ViewProjectionSample.iOS: Crosslight iOS project, works on iPhones and iPad with Storyboard support.
* ViewProjectionSample.WebApi: Microsoft WebAPI project that acts as the mobile server.

#Features Overview

* Ultra-fast data loading with view projection technique
* Filter over collection with Any Filter Descriptor
* The use of cell label component in iOS for indicator
* The use of Segmented Bar Controller and Search Controller in iOS

#Running the Sample

This sample is NuGet-enabled. For more information on restoring NuGet packages, check out this document: [Introduction to Crosslight NuGet Packages](http://developer.intersoftsolutions.com/display/crosslight/Introduction+to+Crosslight+NuGet+Packages#IntroductiontoCrosslightNuGetPackages-RestoringCrosslightPackages). By default, this project automatically points to a WebAPI server hosted in Intersoft's server. You can easily change this URL to your local development machine by running the WebAPI project on a separate instance of Visual Studio then exposing the IISExpress IP address to the local network. For more information, check out this document: [Configuring WebAPI-enabled Crosslight Samples](http://developer.intersoftsolutions.com/display/crosslight/Configuring+WebAPI-enabled+Crosslight+Samples).

##Running on Mac
If you run this sample on Mac Xamarin Studio, all you have to do is just open the solution using Xamarin Studio and the NuGet packages will be restored automatically. Simply set one of the platform projects as start-up projects and run.

##Running on Windows
If you run this sample on Windows Visual Studio, right-click on the solution, then choose Restore NuGet packages. Wait until all the NuGet packages are restored, then simply set one of the platform projects as start-up projects and run.

#Relevant Links
* [Working with View Projection](http://developer.intersoftsolutions.com/display/crosslight/Working+with+View+Projection)
* [iOS Search Controller](http://developer.intersoftsolutions.com/display/crosslight/iOS+Search+Controller)
* [iOS Cell Label](http://developer.intersoftsolutions.com/display/crosslight/iOS+Cell+Label)
* [iOS Segmented Bar Controller](http://developer.intersoftsolutions.com/display/crosslight/iOS+Segmented+Bar+Controller)


Copyright © Intersoft Solutions.
