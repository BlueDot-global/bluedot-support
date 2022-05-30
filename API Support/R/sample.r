library(httr)
library(jsonlite)

pull_case_counts_api <- function(disease_id) {
  api_key = readline(prompt = "Enter your API key: ")
  api_url = paste0("https://developer.bluedot.global/daas/case-count/v1/api/diseases/", disease_id, "/countries")
  res = GET(api_url, add_headers("Ocp-Apim-Subscription-Key" = api_key, "Cache-Control" = "no-cache"))
  data = fromJSON(rawToChar(res$content))
  return(data)
}
