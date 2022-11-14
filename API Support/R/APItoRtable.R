library(httr)
library(jsonlite)
library(tidyverse)
library(GetoptLong)
library(flextable)
library(lubridate)
library(RCurl)
###### get data from API ##########
Step1 <- GET("https://developer.bluedot.global/casecounts/diseases/64?includeSources=True&api-version=v1",
             add_headers("Ocp-Apim-Subscription-Key" = "PUT_SUBSCRIPTION_KEY_HERE", "Cache-Control" = "no-cache"))
Step2 <- content(Step1)
View(Step2)
DataClean = data.frame(t(sapply(Step2$data,c)))
View(DataClean)
Step3 <- apply(DataClean,2,as.character)
View(Step3) #Final data frame

######## Pull sources from previous API pull ##########
# rowID corresponds to original row in the original pulled data (Step 3) to associate the appropriate source
sources <- data.frame(rowId = numeric(),
                      sourceTitle = character(),
                      sourceUrl= character(),
                      publishedDate = character(),
                      sourceCategory= character()) 

for(x in 1:length(DataClean$sources)){
  if(length(DataClean$sources[[x]])==1){
    df <- as.data.frame(DataClean$sources[[x]])
    if(nrow(df) > 0){
      if(ncol(df)>4){
        df_row <- as.data.frame(matrix(unlist(df),ncol=4,byrow=T))
        colnames(df_row) <- c("sourceTitle","sourceUrl","publishedDate","sourceCategory")
        rowId <- rep(x,nrow(df_row))
        df_row <- cbind(rowId,df_row)
      } else{
        rowId <- x
        df_row <- cbind(rowId,df)
      }
      sources <- rbind(sources,df_row)
    }
  } else {
    df_row <- do.call("rbind",DataClean$sources[[x]]) %>% as.data.frame()
    rowId <- rep(x,nrow(df_row))
    df_row <- cbind(rowId,df_row)
    sources <- rbind(sources,df_row)
  }
}

View(sources)#separate dataframe that pulls out sources
