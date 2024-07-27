# MyFirstApplication-IExternalApplication

## Introduction

The Revit Api allows to developers interact and extend the functionalities of the revit Software.
In this exercise we will use IExternalApplication, which is an integral part of the Revit API. The IExternalApplication interface allows developers to create add-ins that load when Revit starts and unload when Revit closes. These add-ins can execute code in response to specific events in the application lifecycle.

This interface has two main methods: **OnStartup(UIControlledApplication application)** y **OnShutdown(UIControlledApplication application).**

**OnStartup(UIControlledApplication application):** This method runs when Revit starts. This is where you can set up the external application, such as adding panels, buttons, or loading other necessary resources.

**OnShutdown(UIControlledApplication application):** This method runs when Revit closes. This is where you can perform necessary cleanup, such as releasing resources or saving settings.

## Target

The objective of this exercise is to create a series of buttons with specific functions that will be placed on the Revit ribbon.

## Solution

## STEP 1 - Add Revit references

  To add the references that allow us connect with the Revit API files, we must:

   - Right Click on Referencias and select Agregar referencia.

   ![image](https://github.com/AndresF-SanchezG/MyFirstApplication-IExternalCommand/assets/113924667/05a8a1c5-4548-40cc-a864-8c24cdfe16ff)

   - In the Reference Manager, select **Examinar.** This will open a file explorer where we need to navigate to the following path: **C:\Program Files\Autodesk\Revit 2024**.In this path,     we select the following files: **RevitAPI.dll** and **RevitAPIUI.dll.**
     

   ![image](https://github.com/AndresF-SanchezG/MyFirstApplication-IExternalCommand/assets/113924667/eac18fe8-e9c0-48f2-8ca7-498642c83b46)
   ![image](https://github.com/AndresF-SanchezG/MyFirstApplication-IExternalCommand/assets/113924667/a3f9794a-5cc8-460e-8df7-5a6016829cec)

     Press Aceptar and in the solution explorer, we can see the added references. With these references, we can have access to the Revit API documents. We set Copia Local to Falso.

   ![image](https://github.com/AndresF-SanchezG/MyFirstApplication-IExternalCommand/assets/113924667/7731dd67-77fc-4468-88b4-429e7cf62f20)
   ![image](https://github.com/AndresF-SanchezG/MyFirstApplication-IExternalCommand/assets/113924667/fa183e5a-76b1-47e3-8e47-952f555de233)
   
## STEP 2 - Generate .addin file

Unlike how the .addin file was created in the IExternalCommand exercise, where the .addin file was created from Notepad, this time we will create it from the code editor. Additionally, we will learn that when we compile the code, the .addin file and the .dll file will automatically be copied to the specified path so that Revit can read our application.

To generate the .addin file, we must follow these steps:

  - Go to the class library
  - Right click
  - Select Add
  - Select Nuevo Elemento
  - In the Add New Item window, type the word 'manifesto' in the search bar and click Add.
    
  ![image](https://github.com/user-attachments/assets/aad39520-e3eb-4f20-ae43-ff467f18f586)

  The template is generated where we will directly create the manifest file.

  ![image](https://github.com/user-attachments/assets/b3a21bfe-8708-46d6-b88f-fdc28a639c04)



