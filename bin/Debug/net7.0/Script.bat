"C:\Program Files\Google\Chrome\Application\chrome.exe"
:loop
	start "Google" "http://amazon.com/"
	timeout -t 10
	goto :loop
