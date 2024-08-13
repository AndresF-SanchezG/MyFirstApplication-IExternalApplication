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

Now, if we want to create more than one panel, we need to copy the line of code and change the name of the panel.

  ![image](https://github.com/user-attachments/assets/ca0bf92f-7c8c-4b2f-82e8-0caa5bfc31ae)

  ![image](https://github.com/user-attachments/assets/790e9d5e-23ba-4a2c-abc9-5f74b7909920)


### Panel within Custom tab

In this section, we will learn how to create a custom tab and panels within this tab. In the code editor, based on the API documentation, we first call the application object and then use the CreateRibbonTab method, which creates a custom tab. After that, we call the CreateRibbonPanel method and assign two parameters: the name of the previously created tab (Tab01) and the name of the panel or panels (Panel001).

  ![image](https://github.com/user-attachments/assets/58c9abda-7d4e-4da3-a7f8-0bf3ea51bb7f)

  ![image](https://github.com/user-attachments/assets/3e2c033f-b4e3-416b-a8be-7e298037c590)

## STEP 4 - PushButton

In this section, we will create a button that meets the following characteristics:
  - This button has to be inside a panel.
  - It has a title and an icon.
  - When we place the mouse pointer over the button, a dialog box should appear containing information such as: Name, a brief description of the button's function, and a help option.
  - When we hold the cursor over the button for a moment, a dialog box should appear containing information such as: Name, a detailed description of the button's function, a reference 
    image, and finally, a help option.

### Button inside of a panel.

To create a PushButton, we must follow these steps:
  - First, we store the panel in a variable of type RibbonPanel. 
  - Create an instance of the PushButtonData class, an object that receives the information for the PushButton. First, we define the name of the object and then initialize the object using the reserved word 'new'. This class receives 4 string parameters: Name, Text, AssemblyName, and Class name.
    **Name:** Button Name;
    **Text:** Button title;
    **AssemblyName:** Is used in C# to obtain the location (file path) of the assembly (DLL or EXE file) where the Class1 type is defined.
    Typeof(Class1): This gets the Type object that represents the Class1 type. In simpler terms, it tells the code to look at the class definition for Class1.
    Assembly: This accesses the Assembly object that represents the compiled code (DLL or EXE) where the Class1 class is defined.
    Location: This retrieves the file path of the assembly (the physical location on disk) where the Class1 class is stored.
    **ClassName:** Name of the class that will execute when we press the button. First, we specify the namespace, then the name of the class that will execute.
  - Finally, we place our button inside the panel.

    ![image](https://github.com/user-attachments/assets/aac49268-6d86-4e4c-b81d-40a664c94983)

    ![image](https://github.com/user-attachments/assets/3861215d-3138-4ec5-bc3f-ff089f34f1bf)

### Add Icon

To add properties (icon, reference image, short description, etc.) to the button, we must use an object of type PushButton. This object allows access to various properties that can be found in the API Docs; in this case, we will use the ones mentioned above.

To have a PushButton object, we first need to modify line **panelDePestaña.AddItem(datosDelPushButton);** as the AddItem method returns a RibbonItem type result, and we require a PushButton type result. To convert the result from RibbonItem to PushButton, we need to call the PushButton class, assign it a name, and use the reserved keyword as follow result type to perform the conversion.

Once we have the PushButton object, we can call the following methods.
  - **pushButton.ToolTip:** Method that assigns a brief description.
  - **pushButton.LongDescription:** Method that assigns a long description.
  - **pushButton.ToolTipImage:** Method that assigns a reference image.
    
      - At this point, we should have an image in PNG format. In the code editor, on the Project tab, select Application Properties.
   
        ![image](https://github.com/user-attachments/assets/f2e4b921-74c6-4089-801e-438260d69af6)

        ![image](https://github.com/user-attachments/assets/cf649185-70d1-437c-bf26-13f910cf8556)

    

        





    










  

  
  
 


  








