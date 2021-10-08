########### Python 3.7 #############

import requests
from requests.structures import CaseInsensitiveDict

try:
    #Gets location information for Japan from the lookup endpoint sample
    url = "https://developer.bluedot.global/daas/lookup/v2/api/locations/names/Japan/types/Country"

    headers = CaseInsensitiveDict()
    headers["Accept"] = "application/json"
    headers["Cache-Control"] = "no-cache"
    headers["Ocp-Apim-Subscription-Key"] = "{Your developer account subscription key from BlueDot DaaS developer portal}"
    #If DaaS BlueDot SSO OAuth APIs is used, the Bearer token needs to be entered
    headers["Authorization"] = "{Bearer token from BlueDot SSO authentication server}"

    resp = requests.get(url, headers=headers)

    print('Response status code: ', resp.status_code)
    data = resp.content
    print('Response content: ', data)

except Exception as e:
    print("[Errno {0}] {1}".format(e.errno, e.strerror))

####################################