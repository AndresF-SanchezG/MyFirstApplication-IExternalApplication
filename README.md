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
    
  ![image](https://github.com/user-attachments/assets/38ff9d2e-2082-4a1e-9259-0efe571ce9bd)

  The template is generated where we will directly create the manifest file.

  ![image](https://github.com/user-attachments/assets/b3a21bfe-8708-46d6-b88f-fdc28a639c04)

  We clear or delete its content since we don't need it.

  ![image](https://github.com/user-attachments/assets/68b6d929-49f8-44d5-bb3d-e221453fe996)

  Once the file is clean, we can copy the tags that were established in the IExternalCommand manifest file and modify the <AddIn Type="Command"> tag to <AddIn Type="Application"> and also modify the <FullClassName>AppIExternalApplication.Class1</FullClassName> tag with its respective name and the <ClientId>9CF15C42-FD1B-48CB-8029-575388BCB987</ClientId> tag with the respective GUID. The other tags can be retained as this is a test file to configure the manifest file.

  ![image](https://github.com/user-attachments/assets/7bb9ac11-7e70-4a77-b6b5-0e6c1a1092c5)

  Once we have established the tags in the manifest file, we proceed to add the command lines that will ensure that when we compile the solution, the .dll file and the .addin file are copied directly to the necessary location.

  To do this, it is necessary to perform the following steps:

  - Select Proyecto
  - Select Propiedades de "Nombre de Proyecto" 

  ![image](https://github.com/user-attachments/assets/adb96f01-f5de-4f27-b91f-9033931b79c5)
  
  - Select Eventos de Compilacion
  - We write two command lines that will copy the two types of files (.dll and .addin) to the specified path once the solution is compiled.

  ![image](https://github.com/user-attachments/assets/6a4ab4b0-77a3-4877-8e7f-016af5e4c9f3)

  Note that once the solution has been compiled, the .dll and .addin files have been copied to the path we established.

  ![image](https://github.com/user-attachments/assets/3cd23aa6-8fed-4242-9f42-32f3f933d1cf)

## STEP 3 - Ribbon and Panel

In this section, we will learn to create custom panels where we will place our tools. First, we will do this within the 'Complementos' tab, and later, we will create our own custom tab.

### Panel within Complementos tab

  ![image](https://github.com/user-attachments/assets/cb0ce1e2-dd27-463b-a793-edc783dcbfb4)

In the code editor and based on the API docs, we first call the application object and then call the CreateRibbonPanel method, which automatically creates the panel in the Complementos tab. We assign a string parameter with the name of the panel (Panel01).

  ![image](https://github.com/user-attachments/assets/1f94b61e-b40b-4080-a57d-ad01b861f0be)

  ![image](https://github.com/user-attachments/assets/f1a777bc-66f7-46a6-b26c-1d0a07a719a3)

  
  
 


  








