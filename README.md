# MyFirstApplication-IExternalApplication

## Introduction

The Revit Api allows to developers interact and extend the functionalities of the revit Software.
In this exercise we will use IExternalApplication, which is an integral part of the Revit API. The IExternalApplication interface allows developers to create add-ins that load when Revit starts and unload when Revit closes. These add-ins can execute code in response to specific events in the application lifecycle.

This interface has two main methods: **OnStartup(UIControlledApplication application)** y **OnShutdown(UIControlledApplication application).**

**OnStartup(UIControlledApplication application):** This method runs when Revit starts. This is where you can set up the external application, such as adding panels, buttons, or loading other necessary resources.

**OnShutdown(UIControlledApplication application):** This method runs when Revit closes. This is where you can perform necessary cleanup, such as releasing resources or saving settings.

## Target

The objective of this exercise is
