# K2Documentation.Samples.Extensions.SmartForms.CustomControl
Sample code that demonstrates how to programmatically extend the functionality and look of the standard set of controls provided with K2 smartforms.

This project contains sample code that demonstrates how to build basic custom controls and then expand on them. The code samples are arranged in folders within the solution and demonstrate the following basic custom control functionality:
* BasicControl - The Basic Custom Control
* JavaScriptControl - The Custom Control with JavaScript
* StyleControl - The Custom Control with Style Sheet
* ExampleControls - The Custom Control with style properties
* ControlUsingResource - Control using custom resource files
* IconControl - Adding an icon to Custom Control
* CustomControlGetSet - Custom Control using Get and Set values

## Prerequisites
The sample code has the following dependencies: 
* .NET Assemblies (the K2 client-side tools install includes the assemblies and they are also included in the project's References folder)
  * SourceCode.Forms.Client.dll
  * SourceCode.Forms.Controls.Web.dll
  * SourceCode.Forms.Controls.Web.SDK.dll
  * SourceCode.Forms.Controls.Web.Shared.dll
  * SourceCode.HostClientAPI.dll

## Getting started
* Use these code snippets to learn about building basic custom controls. This project demonstrates how to extend the basic custom control. 
* Note that as this project is only sample code, it may compile but will not actually run as-is. You will need to edit the code snippets to work in your environment and with your artifacts. 
* Fetch or Pull the appropriate branch of this project for your version of K2. 
* Consider the Master branch the latest, up-to-date version of the sample project. Branches contain older versions. For example, there may be a branch called K2-Five-5.0 that is specific to K2 Five version 5.0. There may be another branch called K2-Five-5.3 that is specific to K2 Five version 5.3. Assume that the master branch represents the latest release version of K2 Five. 
* The Visual Studio project contains a folder called "References" where you can find the referenced .NET assemblies or other uncommon assemblies. By default, try to reference these assemblies from your own environment for consistency, but we provide the referenced assemblies as a convenience in case you are not able to locate or use the referenced assemblies in your environment. 
* The Visual Studio project contains a folder called "Resources". This folder contains additional resources that may be required to use the same code, such as K2 deployment packages, sample files, SQL scripts and so on. 
   
## License
This project is licensed under the MIT license. Find the MIT license in LICENSE.

## Notes
 * The sample code is provided as-is without warranty.
 * These sample code projects are not supported by K2 product support. 
 * The sample code is not necessarily comprehensive for all operations, features or functionality. 
 * We only accept code contributions that are compatible with the MIT license (essentially, MIT and Public Domain).
