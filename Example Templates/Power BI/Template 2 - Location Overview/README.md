# BlueDot Example Template 2: Location Overview

## Download

Download the latest version of the template [here](https://github.com/BlueDot-global/bluedot-support/raw/main/Example%20Templates/Power%20BI/Template%202%20-%20Location%20Overview/template2-location-overview-v2.1.0.pbix)

## Versions

##### [2.1.0](https://github.com/BlueDot-global/bluedot-support/raw/LOCOVERv2.1.0/Example%20Templates/Power%20BI/Template%202%20-%20Location%20Overview/template2-location-overview-v2.1.0.pbix)
- Released October 11, 2022
- Template renamed to _Location Overview_, adding sense and clarity to its purpose and utility
- Page titles updated to improve readability

##### [2.0.0](https://github.com/BlueDot-global/bluedot-support/raw/IDRLv2.0.0/Example%20Templates/Power%20BI/Infectious%20Disease%20Risk%20by%20Location/infectious-disease-risk-by-location-v2.0.0.pbix)
- Released August 19, 2022
- Added references to source information for BlueDot intelligence on cases and deaths
- Added references to source information for BlueDot intelligence on new, notable, and unusual activity updates (i.e. "Recent News")
- Improved disease profile statements
- Implemented bug fixes on case incidence, BEPI, hospital beds. Statements will now display if there is no data available.

##### [1.1.0](https://github.com/BlueDot-global/bluedot-support/raw/IDRLv1.1.0/Example%20Templates/Power%20BI/Infectious%20Disease%20Risk%20by%20Location/infectious-disease-risk-by-location.pbix)
- Released June 24, 2022
- Added new, notable, and unusual activity page
- Updated subnational map to include case incidence and population
- Improved disease profile information
- Implemented bug fixes related to case counts

##### [1.0.0](https://github.com/BlueDot-global/bluedot-support/raw/IDRLv1.0.0/Example%20Templates/Power%20BI/Infectious%20Disease%20Risk%20by%20Location/infectious-disease-risk-by-location.pbix)
- Released April 12, 2022
- Initial release of the template (formerly known as _Infectious Disease Risk by Location_)

## Overview

- [Functionality](#functionality)
- [Access the template and connect to BlueDot's live intelligence](#access-the-template-and-connect-to-bluedots-live-intelligence)
- [Reach out to BlueDot for support](#reach-out-to-bluedot-for-support)

## Functionality

BlueDot’s Template 2: Location Overview enables users to pinpoint and understand infectious disease risks within locations of interest. With this template, users can clearly understand infectious disease risk and activity for specified locations, including total reported cases, deaths, incidence rates, and disease characteristics (severity, transmissibility, mode of transmission, and preventability). In addition, users gain greater context to key indicators with information regarding epidemic preparedness by location and relevant recent news. This template is part of a series of infectious disease intelligence example templates created by BlueDot.

This template consists of the following pages:
- [Location Search](#location-search-page)
- [Location Overview](#location-overview-page)
- [Disease Activity](#disease-activity-page)
- [Drill Down Page: More Recent News](#drill-down-page-more-recent-news)
- [Data Dictionary & Methods](#data-dictionary--methods-page)

### Location Search Page

Location Search is the home page of this template, using which users can filter down the location of interest within a desired timeframe.
To select a location, users have to:
1. Search location  (hit enter/return after entering the country of interest in the search box) OR
2. Select location, right-click on the location and click on `Drill through > Location Profile` or left-click `View`. 

_Note: Only one location, at a country level, can be selected at this time._

![Location and Timeframe Search](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%202%20-%20Location%20Overview/Screenshots/location-overview-1.png)

_Image 1: Location and timeframe search_

### Location Overview Page

This page gives an overview of all disease activity in the selected time frame and country location, the baseline epidemic preparation index (BEPI) developed by BlueDot, and the number of hospital beds per 10,000 in this location as listed by the World Health Organization (WHO). Furthermore, notable disease events in the location selected will be previewed here. 

The disease overview table sources column shows the number, and type of sources used to generate disease intelligence and case counts. 

![Location Profile Overview](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%202%20-%20Location%20Overview/Screenshots/location-overview-2.png)

![BEPI and Hospital Beds Data](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%202%20-%20Location%20Overview/Screenshots/location-overview-3.png)

_Image 2: Location Overview_

To see additional intelligence for a specific disease and the sources associated with the reports, select the disease from the **Disease List** table and click `View Disease Activity`. Alternatively, diseases can be selected by right clicking the disease, and selecting `Drill Through > Disease Activity`.

### Disease Activity Page

This section of the report displays additional intelligence for the selected disease, in the previously selected location. It also includes intelligence on reported cases and reported deaths via summary sentences, as well as a graph showing reported cases and deaths over time. Additionally, reported case incidence by subnational geographies are displayed on a map.  To view the intelligence in the map as a table, select the grid icon in the right corner of the graph.  The subnational map of case incidences can also be displayed as a table by toggling between the `List view` and `Map view`. 

![Disease Activity Page](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%202%20-%20Location%20Overview/Screenshots/location-overview-4.png)

![Subnational Data](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%202%20-%20Location%20Overview/Screenshots/location-overview-5.png)

_Image 3: Disease Activity_ 
 
The Disease Profile section is located below the subnational map. This section includes information on disease severity, transmissibility, preventability, and modes of transmission. The information displayed in this area changes based on the user's selection of disease in the Location Search and Location Profile pages.

At the bottom of the page, the `Data Sources` table can be found. Here, sources for reported intelligence used during the selected time period are displayed.

![DataSources](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%202%20-%20Location%20Overview/Screenshots/location-overview-24.png)

_Image 4: Data Sources Table_ 

### Drill Down Page: More Recent News

This page displays recent BlueDot new, notable and unusual activity updates relevant to the selected location. There are three categories of reports shown: breaking news, situational updates, and new activity. The descriptions of topics covered by each of these report categories can be found in the [Data Dictionary and Methods page](#data-dictionary--methods-page).

The user can filter through BlueDot updates based on the diseases reported in the location, the type of article, and adjust the timeframe as needed. If no filters are specified, all reports will be shown. 

Lastly, links to sources that informed details of the updates can be found beside the summary of the event. 

![Recent News and Notable Disease Events Page](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%202%20-%20Location%20Overview/Screenshots/location-overview-6.png)

_Image 5: More Recent News_

### Data Dictionary & Methods page

The Data Dictionary & Methods page can be found on the last tab of the template. Definitions for all terms used in the template will be listed here. 

![Data Dictionary and Methods](https://github.com/BlueDot-global/bluedot-support/blob/main/Example%20Templates/Power%20BI/Template%202%20-%20Location%20Overview/Screenshots/location-overview-7.png)

_Image 6: Data Dictionary and Methods_

## Access the template and connect to BlueDot's live intelligence

For access to this template, please contact your BlueDot client and partner success representative, or email support@bluedot.global.  

The template can be viewed via the desktop application, Power BI Desktop, or through the Power BI web service hosted by Microsoft. Individuals using operating systems other than Windows will have a better user experience using the web service. 

### Connect to BlueDot's live intelligence

_Template 2: Location Overview_ comes with sample data by default. Please, reach out to BlueDot support for live data pricing and credentials. You can connect to BlueDot’s live intelligence within the Power BI desktop app.

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

To use _Template 2: Location Overview_ in Power BI Service, please follow the steps above to [connect to BlueDot’s live intelligence](#within-the-power-bi-desktop-app), and then publish the template to your PowerBI workspace.

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