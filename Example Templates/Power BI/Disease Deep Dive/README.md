# BlueDot Example Template: Disease Deep Dive  

## Download  

Download the latest version of the template [here](https://github.com/BlueDot-global/bluedot-support/raw/main/Example%20Templates/Power%20BI/Disease%20Deep%20Dive/disease-deep-dive-v1.0.0.pbix) 

## Versions  

##### [1.0.0](https://github.com/BlueDot-global/bluedot-support/raw/DDDv1.0.0/Example%20Templates/Power%20BI/Disease%20Deep%20Dive/disease-deep-dive-v1.0.0.pbix) 
- Released August 18, 2022 
- Initial release of Disease Deep Dive template 

## Overview 

- [Functionality](#functionality)
- [Access the template and connect to BlueDot's live intelligence](#access-the-template-and-connect-to-bluedots-live-intelligence)
- [Reach out to BlueDot for support](#reach-out-to-bluedot-for-support)

## Functionality  

BlueDot’s Disease Deep Dive example template provides detailed activity for a selected infectious disease at the national and subnational level. After choosing a disease and location, users get an in-depth understanding of local activity for that disease - including subregional case and death intelligence (in-year and historical), year-over-year seasonal trends, regions experiencing increases or decreases of cases, disease characteristics (severity, preventability, and modes of transmission), and more. This template is a part of series of infectious disease intelligence PowerBI templates created by BlueDot.  

This template consists of the following pages:  
- [Disease and Location Search](#disease-and-location-search-page) 
- [National Overview](#national-overview-page) 
- [Subnational Profile](#subnational-profile-page) 
- [Subnational Overview](#subnational-overview-page) 
- [Data Dictionary & Methods](#data-dictionary--methods-page) 

### Disease and Location Search Page  

The Disease and Location Search is the landing page where filters can be applied for the report. Filtering consists of the following steps:  

1. Select a disease of interest 
2. Select the timeframe of the report 
3. Search National OR Subnational location  
4. Select National OR Subnational location (click ‘View National Location’ or ‘View Subnational Location’) 

![Disease and Location search](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Disease%20Deep%20Dive/Screenshots/deep-dive-1.png) 

_Screenshot 1: Disease, timeframe, and location search_  

### National Overview page  

This page shows an overview of the selected disease in the national location of interest. Disease intelligence statements outlining the case incidence (raw and per 100,000), the number of reported deaths (raw and per 100,000) during the selected time period are displayed at the top. Additionally, the trend in cases within 90 days of the last case report, compared to the same time period last year, is found under _YoY change in cases_. Disease intelligence surrounding case incidence and reported deaths, historically is displayed the two graphs shown below. 

![National overview page](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Disease%20Deep%20Dive/Screenshots/deep-dive-2.png) 

_Screenshot 2: National Overview Page_ 

The Disease Profile section is located at the bottom of the National Overview Page. This section includes information on disease severity, preventability, and the modes of transmission of the disease of interest. The information displayed in this area changes based on the user’s selection of disease in the search page.  

![National overview page](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Disease%20Deep%20Dive/Screenshots/deep-dive-3.png) 

_Screenshot 3: National Overview Page_  

At the top of the National Overview page, you can select “Subnational Disease Activity” to view the Subnational Profile page. 

### Subnational Profile page 

This page contains disease intelligence at a subnational level. Users can see trends at a subnational level, including which regions demonstrated the highest number of cases, the greatest increase, and decrease of cases from the most recent 90 days, compared to the same time period, last year. The map highlights regions reporting cases, with a table beneath to show the reported cases, deaths, and year-over-year trends in that region.  

![National overview page](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Disease%20Deep%20Dive/Screenshots/deep-dive-4.png) 

_Screenshot 4: Subnational Summary Page_ 

### Subnational Overview page 

This page is similar to the National Overview page, but for the subnational location selected on the Search page. 

![Subnational Overview](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Disease%20Deep%20Dive/Screenshots/deep-dive-5.png) 

![Subnational Overview](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Disease%20Deep%20Dive/Screenshots/deep-dive-6.png) 

_Screenshot 5: Subnational Overview_ 

### Data Dictionary & Methods page 
 
The Data Dictionary & Methods page can be found on the last tab of the template. Definitions for all terms used in the template will be listed here. 

![DataDictionary](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Disease%20Deep%20Dive/Screenshots/deep-dive-7.png) 

_Screenshot 6: Data Dictionary and Methods page_ 

## Access the template and connect to BlueDot's live intelligence 
 
For access to this template, please contact your BlueDot client and partner success representative, or email support@bluedot.global.   
 
The template can be viewed via the desktop application, Power BI Desktop, or through the Power BI web service hosted by Microsoft. Individuals using operating systems other than Windows will have a better user experience using the web service.  
 
### Connect to BlueDot's live intelligence 
 
The “BlueDot Example Template: Disease Deep Dive” comes with sample intelligence by default. Please, reach out to BlueDot support for live intelligence pricing and credentials. You can connect to BlueDot’s live intelligence within the Power BI desktop app. 

### Please refresh your data before use to ensure that the most accurate and up-to-date information is displayed. 
 
### Within the Power BI desktop app 
 
1. Select `Data Source settings` from the drop-down menu of the Data Icon. 
 
![Data Source Settings Toolbar Item](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Infectious%20Disease%20Risk%20by%20Location/Screenshots/id-risk-by-loc-8.jpg) 
 
2. Select `Change Source...`. 
 
![Data Source Settings](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Infectious%20Disease%20Risk%20by%20Location/Screenshots/id-risk-by-loc-9.jpg) 
 
3. Enter in Server: `sqldb-bd-epi-intelligence.database.windows.net`. 
 
4. Enter in Database: `BluedotDashboardsData`. 
 
5. Click `OK`. 
 
![SQL Server Database Parameters](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Infectious%20Disease%20Risk%20by%20Location/Screenshots/id-risk-by-loc-10.jpg) 
 
6. Next, click `Edit Permissions...`. 
 
![Data Source Settings](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Infectious%20Disease%20Risk%20by%20Location/Screenshots/id-risk-by-loc-11.jpg) 
 
 
7. Click `Edit`. 
 
![Data Source Permissions](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Infectious%20Disease%20Risk%20by%20Location/Screenshots/id-risk-by-loc-12.jpg) 
 
 
8. Ensure that `Database` is selected. 
 
9. Input valid credentials under `User name` and `Password`. 
 
10. Click `Save`. 
 
![SQL Server Database Credentials](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Infectious%20Disease%20Risk%20by%20Location/Screenshots/id-risk-by-loc-13.jpg) 
 
11. Click `OK` and `Close`. 
 
![Data Source Permissions](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Infectious%20Disease%20Risk%20by%20Location/Screenshots/id-risk-by-loc-14.jpg) 
 
12. Click "Refresh" in the toolbar. 
 
![Refresh Toolbar Item](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Infectious%20Disease%20Risk%20by%20Location/Screenshots/id-risk-by-loc-15.jpg) 
 
### Using the template within the Power BI service 
 
To use the Infectious Disease Risk by Location example template in Power BI Service, please follow the steps above to [access the template](#Access-the-template-and-connect-to-BlueDot's-live-intelligence), and then publish the template to your PowerBI workspace. 
 
1. Navigate to the workspace where the template has been published. 
 
2. Click on the three dots beside the corresponding dataset and click on `Settings`. 
 
![Dataset Settings](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Infectious%20Disease%20Risk%20by%20Location/Screenshots/id-risk-by-loc-19.png) 
 
3. Expand on `Parameters`. 
 
![Dataset Parameters](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Infectious%20Disease%20Risk%20by%20Location/Screenshots/id-risk-by-loc-20.png) 
 
4. Enter in Database: `BluedotDashboardsData`. 
 
5. Enter in Server: `sqldb-bd-epi-intelligence.database.windows.net`. 
 
6. Click on `Apply`. 
 
7. Expand on `Data source credentials`. 
 
![Data source credentials](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Infectious%20Disease%20Risk%20by%20Location/Screenshots/id-risk-by-loc-21.png) 
 
8. Click on `Edit Credentials`. 
 
![Data source credentials](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Infectious%20Disease%20Risk%20by%20Location/Screenshots/id-risk-by-loc-22.png) 
 
9. Input valid credentials under `Username` and `Password`. 
 
10. Click on `Sign in`. 
 
11. If desired, dataset can be automatically refreshed to always have the most up-to-date data. Expand on `Scheduled refresh`. 
 
![Data source credentials](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Infectious%20Disease%20Risk%20by%20Location/Screenshots/id-risk-by-loc-23.png) 
 
12. Toggle `On`. 
 
13. Set the desired frequency of data update. 
 
14. Click on `Apply`. 
 
### Uploading new visuals created by BlueDot 
 
BlueDot will continuously be making improvements to templates. As a result, a visual or component of the template may be updated. When a new update has been published, your Client and Partner Success representative will send you a notification that an update will be available in BlueDot’s GitHub page.  
 
After downloading the updated component, it can be added to an existing template through the following steps:  
 
1. Under the **Visualizations** pane, select the three dots shown below. 
 
![Visualizations Pane](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Infectious%20Disease%20Risk%20by%20Location/Screenshots/id-risk-by-loc-17.png) 
 
2. Select `Import Visualizations from a file`. 
 
![Build Visual Options](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Infectious%20Disease%20Risk%20by%20Location/Screenshots/id-risk-by-loc-18.png) 
 
3. Select the new component from your file finder.  
 
4. A new icon should appear. Upon clicking the new icon, the visual will appear in the report. 
 
 
## Reach out to BlueDot for support 
 
Please, do not hesitate to reach out to BlueDot support at support@bluedot.global. 