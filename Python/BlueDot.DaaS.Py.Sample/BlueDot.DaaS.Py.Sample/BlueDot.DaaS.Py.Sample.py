########### Python 3.10.1 #############

import requests
from requests.structures import CaseInsensitiveDict

try:
 #Code block-1######################
    #This is the first code block which, is a sample of calling BlueDot DaaS API
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
    
 #Code block-2######################
     #This is the second code block which, is a sample of listening to BlueDot DaaS push notification azure service bus
    #For more information on using azure service bus, go to:
    # https://docs.microsoft.com/en-us/python/api/overview/azure/servicebus-readme?view=azure-python

    from azure.servicebus import ServiceBusClient, ServiceBusMessage

    connstr = "{Your SERVICE_BUS_CONNECTION_STR}"
    topic_name = "{Your SERVICE_BUS_TOPIC_NAME}"
    subscription_name = "{Your SERVICE_BUS_SUBSCRIPTION_NAME}"

    with ServiceBusClient.from_connection_string(connstr) as client:
        # If session_id is null here, will receive from the first available session.
        with client.get_subscription_receiver(topic_name, subscription_name) as receiver:
            for msg in receiver:
                print(str(msg))

except Exception as e:
    print("[Errno {0}] {1}".format(e.errno, e.strerror))

####################################