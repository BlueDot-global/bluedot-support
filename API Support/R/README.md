# BlueDot DaaS R Sample

BlueDot DaaS APIs can be accessed by providing an API Key (subscription key tied to your account). The following code snippet will work with R.

## Using API Key

The following sample uses [httr library](https://github.com/r-lib/httr) to send the GET request.
Replace `<API_KEY>` with the key provided with your account.
Full code available [here](sample.r).

    url = 'https://developer.bluedot.global/daas/case-count/v1/api/diseases/'
    headers = {'Ocp-Apim-Subscription-Key': '<API_KEY>'}

## Running [sample.r](sample.r)

Open R terminal (in RGui, R Studio, VS Code or any other tool of your preference) and run the following commands to install required packages.

    install.packages("httr")
    install.packages("jsonlite")

To execute sample code you can slightly modify it to add output of data and run all from the terminal. In this example we request data for disease with ID = 55

    res = pull_case_counts_api(55)
    res
