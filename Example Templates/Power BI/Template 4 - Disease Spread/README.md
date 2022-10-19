# BlueDot Example Template 4: Disease Spread

## Download

Download the latest version of the template [here](https://github.com/BlueDot-global/bluedot-support/raw/main/Example%20Templates/Power%20BI/Template%204%20-%20Disease%20Spread/template4-disease-spread-v1.0.0.pbix)

## Versions

##### [1.0.0](https://github.com/BlueDot-global/bluedot-support/raw/DISSPRv1.0.0/Example%20Templates/Power%20BI/Template%204%20-%20Disease%20Spread/template4-disease-spread-v1.0.0.pbix)
- Released Oct 19, 2022
- Initial release of Template 4: Disease Spread

## Overview
- [Functionality](#functionality)
- [Access the template and connect to BlueDot's live intelligence](#access-the-template-and-connect-to-bluedots-live-intelligence)
- [Reach out to BlueDot for support](#reach-out-to-bluedot-for-support)

## Functionality

BlueDot’s Template 4: Disease spread provides the range of forecasted likelihood that at least one infected traveller would arrive at a destination, over the next 30 days. Users can see results at a country or airport level. The location pairings available to the user are airport to airport, airport to worldwide, country to country, country to worldwide, worldwide to airport, and worldwide to country. Furthermore, users will be able to filter the results based on disease severity. This template is a part of series of infectious disease intelligence PowerBI templates created by BlueDot.

This template consists of the following pages:
- [Location Scope Selection](#location-scope-selection)  
- [Importation Likelihood Results Page](#importation-likelihood-results-page)
- [Data Dictionary and Methods](#data-dictionary-and-methods)  
- [Help Page](#help-page)

### Location Scope Selection

The Location Scope Selection page is the landing page where users can select the desired granularity of which the importation likelihood will be displayed as. Multiple origins/destinations can be selected. Furthermore, users will be able to choose their origin and destination pairings of interest.  This involves the following steps:

1. Select an Origin Scope (airport, country, worldwide).
   1. Select a origin location (based on the scope selected)
2. Select a destination Scope (airport, country, worldwide).
   1. Select a destination location (based on the scope selected)

To start a new selection, use the `Reset Selection` buttons for each filter to clear previous selections.

Note on Data Output: Results will be displayed at the level of selected location scope. If a pairing involves a destination or origin airport, importation likelihood will be shown at the airport level. Likewise, if a pairing involves a destination or origin country, importation likelihood will be shown at an aggregated country level. Any pairing involving "Worldwide" will have likelihood aggregated at a worldwide level. However, only one million rows can be displayed in this template. To view results for pairings that produce more than one million rows, please use our API access. Contact your Client and Partner Success representative for more information.      
![Disease Spread Search Page](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%204%20-%20Disease%20Spread/Screenshots/disease-spread-disease-spread-search-page.png)  

_Image 1: Location selection_

#### Importation Likelihood Results Page

This page shows an overview of the likelihood of importation of diseases to the selected location pair.  Diseases displayed in the results table can be filtered by severity in the table on the top right. As mentioned, the results displayed on this page will correspond to the level of location scope selected. Importation likelihood is presented as a range and classified by unlikely, low, moderate, high, and very high. The severity level of disease is calculated regardless of the importation likelihood reported.
![Disease Spread Results Page](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%204%20-%20Disease%20Spread/Screenshots/disease-spread-disease-spread-results-page.png)

_Image 2: Importation Likelihood results page_

### Data Dictionary and Methods
The Data Dictionary and Methods page can be found on the last tab of the template. Definitions for all terms used in the template will be listed here, along with a short description of the importation likelihood model.

![Data Dictionary](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%204%20-%20Disease%20Spread/Screenshots/disease-spread-data-dictionary-1.png)
![Data Dictionary Continuation](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%204%20-%20Disease%20Spread/Screenshots/disease-spread-data-dictionary-2.png)

_Image 3: Data Dictionary and Methods page_

### Help Page
The help page displays tips on how to make the best use out of this template. Additionally, it will give some context into the types of location pairings allowed, how to get the most use out of the location filters, and data limitations. If you would like a further explanation of this template, please contact your Client and Partner Success representative.

![Help Page Location Combination](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%204%20-%20Disease%20Spread/Screenshots/disease-spread-help-page-1.png)
![Help Page Search Filters](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%204%20-%20Disease%20Spread/Screenshots/disease-spread-help-page-2.png)
![Help Page Data Limitations](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%204%20-%20Disease%20Spread/Screenshots/disease-spread-help-page-3.png)

_Image 4: Help page_

## Access the template and connect to BlueDot's live intelligence

For access to this template, please contact your BlueDot client and partner success representative, or email support@bluedot.global.

The template can be viewed via the desktop application, Power BI Desktop, or through the Power BI web service hosted by Microsoft. Individuals using operating systems other than Windows will have a better user experience using the web service.

### Connect to BlueDot's live intelligence

_Template 4: Disease Spread_ comes with sample intelligence by default. Please, reach out to BlueDot support for live intelligence pricing and credentials. You can connect to BlueDot’s live intelligence within the Power BI desktop app.

#### Please refresh your data before use to ensure that the most accurate and up-to-date information is displayed.

### Within the Power BI desktop app

1. Select `Data Source settings` from the drop-down menu of the Data Icon.

![Data Source Settings Toolbar Item](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%202%20-%20Location%20Overview/Screenshots/location-overview-8.jpg)

2. Select `Change Source...`.

![Data Source Settings](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%202%20-%20Location%20Overview/Screenshots/location-overview-9.jpg)

3. Enter in Server: `sqldb-bd-epi-intelligence.database.windows.net`.

4. Enter in Database: `BluedotDashboardsData`.

5. Click `OK`.

![SQL Server Database Parameters](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%202%20-%20Location%20Overview/Screenshots/location-overview-10.jpg)

6. Next, click `Edit Permissions...`.

![Data Source Settings](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%202%20-%20Location%20Overview/Screenshots/location-overview-11.jpg)

7. Click `Edit`.

![Data Source Permissions](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%202%20-%20Location%20Overview/Screenshots/location-overview-12.jpg)

8. Ensure that `Database` is selected.

9. Input valid credentials under `User name` and `Password`.

10. Click `Save`.

![SQL Server Database Credentials](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%202%20-%20Location%20Overview/Screenshots/location-overview-13.jpg)

11. Click `OK` and `Close`.

![Data Source Permissions](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%202%20-%20Location%20Overview/Screenshots/location-overview-14.jpg)

12. Click "Refresh" in the toolbar.

![Refresh Toolbar Item](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%202%20-%20Location%20Overview/Screenshots/location-overview-15.jpg)

### Using the template within the Power BI service

To use _Template 4: Disease Spread_ in Power BI Service, please follow the steps above to [connect to BlueDot’s live intelligence](#within-the-power-bi-desktop-app), and then publish the template to your PowerBI workspace.

1. Navigate to the workspace where the template has been published.

2. Click on the three dots beside the corresponding dataset and click on `Settings`.

![Dataset Settings](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%202%20-%20Location%20Overview/Screenshots/location-overview-19.png)

3. Expand on `Parameters`.

![Dataset Parameters](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%202%20-%20Location%20Overview/Screenshots/location-overview-20.png)

4. Enter in Database: `BluedotDashboardsData`.

5. Enter in Server: `sqldb-bd-epi-intelligence.database.windows.net`.

6. Click on `Apply`.

7. Expand on `Data source credentials`.

![Data source credentials](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%202%20-%20Location%20Overview/Screenshots/location-overview-21.png)

8. Click on `Edit Credentials`.

![Data source credentials](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%202%20-%20Location%20Overview/Screenshots/location-overview-22.png)

9. Input valid credentials under `User name` and `Password`.

10. Click on `Sign in`.

11. If desired, dataset can be automatically refreshed to always have the most up-to-date data. Expand on `Scheduled refresh`.

![Data source credentials](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%202%20-%20Location%20Overview/Screenshots/location-overview-23.png)

12. Toggle `On`.

13. Set the desired frequency of data update.

14. Click on `Apply`.

### Uploading new visuals created by BlueDot

BlueDot will continuously be making improvements to templates. As a result, a visual or component of the template may be updated. When a new update has been published, your Client and Partner Success representative will send you a notification that an update will be available in BlueDot’s GitHub page.

After downloading the updated component, it can be added to an existing template through the following steps:

1. Under the **Visualizations** pane, select the three dots shown below.

![Visualizations Pane](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%202%20-%20Location%20Overview/Screenshots/location-overview-17.png)

2. Select `Import Visualizations from a file`.

![Build Visual Options](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%202%20-%20Location%20Overview/Screenshots/location-overview-18.png)

3. Select the new component from your file finder.

4. A new icon should appear. Upon clicking the new icon, the visual will appear in the report.

## Reach out to BlueDot for support

Please, do not hesitate to reach out to BlueDot support at support@bluedot.global.