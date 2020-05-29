# OpenBattery                 <img src="doc/LOGO_2.png" with="110" height="110">

*Want to find the best battery for your product among all the available in the market?*                                       
*Want to compare the battery you created with all the other commerciallly available?*

OpenBattery will provide you all the information and more!

OpenBattery is a high performance open source relational database for academics and industry working with battery.
The platform is available on Microsoft Azure and users can access it to add data too!
This is a transformational resource to develop and validate machine learning and physics based models for the design, prediction, and optimization of battery performance under a wide range of use cases.

**Gantt Chart**

<img src="doc/05_27_Gantt.png">


**PROBLEMS**
- Figuring out how to put the Stanford and MIT battery data inside our database on Azure in a fast and efficient way
- Understanding how much storage we need for the data (do we wanna use also Schwartz group data?)
- Estimating the cost of the whole process to understand which subscription to use
- Creating the Web App through Azure

**SQL SERVER**

Relational databases are very useful when we want to manage structured data via schema, constraints and relationship.

Structured Query Language (SQL) is a standard language for storing, manipulating and retrieving data in databases.

A database in SQL Server is made up of a collection of tables that stores a specific set of structured data. A table contains a collection of rows, also referred to as records or tuples, and columns, also referred to as attributes. Each column in the table is designed to store a certain type of information, for example, the type of electrode, electrolyte and separator of a battery.

We created our version zero of the schema on SQL Server Management Studio (SSMS) and Azure Data Studio from Microsoft.
These servers are used for the access, configuration, management, administration and development of all components of Azure SQL database.

We called our SQL Server in SSMS/Azure Data Studio *"macrobattery-2020.database.windows.net"* and our version 0 schema *"Battery-Database-v0"*:

<img src="doc/macrobattery_database.png">

Inside the *"Battery-Database-v0"* we created the tables:

<img src="doc/Tables.png">

And inside each tables we created columns containing the specific informations of the tables:

<img src="doc/cell_columns.png">

<img src="doc/columns.png">

Tables are database objects that contain all the data in a database. In tables, data is logically organized in a row-and-column format similar to a spreadsheet. Each row represents a unique record, and each column represents a field in the record. 

***N.B*** : We do not upload the data given from Schwartz group because the repo is public and they haven't been published yet.

**Azure Web App**

We want to create a User interface design Webpage with the relational database created on Azure. To do that we can use the function of *"Web App"* in the Azure cloud.

**Cost Estimation**

To estimate the cost of our Azure project, we used the <a href="https://azure.microsoft.com/it-it/pricing/calculator/">Azure Price Calculator. 
  Thanks to this service, we were able to select the Azure products that we needed (Azure SQL Database, DataFactory, Storage account and Web app service). When we selected a product, we were able to select the specific features we needed and see the cost of the product changing. At the end, we exported the whole price calculation in an excel file which summarized the cost of our products selection:
<img src="doc/cost_prediction.png">
