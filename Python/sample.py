import requests

# Replace with credentials provided with your account
API_KEY = '<API_KEY_HERE>'
OAUTH_TOKEN = '<OAUTH_TOKEN_HERE>'


def get_data_by_api_key():
    """Obtains disease data using an API key"""
    url = 'https://developer.bluedot.global/daas/disease/v1/api/10'
    headers = {'Cache-Control': 'no-cache', 'Ocp-Apim-Subscription-Key': API_KEY}

    r = requests.get(url, headers=headers)
    print(r.text)


def get_data_by_oauth_token():
    """Obtains disease data using an OAuth token"""
    url = 'https://developer.bluedot.global/daas/disease/v1/api/10'
    headers = {'Cache-Control': 'no-cache', 'Authorization': f'bearer {OAUTH_TOKEN}'}

    r = requests.get(url, headers=headers)
    print(r.text)


if __name__ == '__main__':
    get_data_by_api_key()
    get_data_by_oauth_token()
