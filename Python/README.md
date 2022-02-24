# BlueDot DaaS Python Sample

BlueDot DaaS APIs can be accessed either by providing an API Key (subscription key tied to your account) or by  providing an OAuth Token. 

## Using API Key
The following sample uses [requests HTTP library](https://docs.python-requests.org/en/latest/) to send the GET request.
Replace `<API_KEY>` with the key provided with your account.
Full code available [here](sample.py).

    url = 'https://developer.bluedot.global/daas/disease/v1/api/10'
    headers = {'Ocp-Apim-Subscription-Key': '<API_KEY>'}

## Using OAuth Token
The following sample uses [requests HTTP library](https://docs.python-requests.org/en/latest/) to send the GET request.
Replace `<OAUTH_TOKEN>` with the token provided with your account.
Full code available [here](sample.py). 

    url = 'https://developer.bluedot.global/daas/disease/v1/api/10'
    headers = {'Authorization': f'bearer {OAUTH_TOKEN}'}
