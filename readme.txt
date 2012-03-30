For this homework assignment I made a dll that gets the weather from the NOAA's REST service. Then I made an application with a menu to access the dll.

Usage:  MyDynamicLibrary.weatherRESTquery.Get_URI(string lat, string lon, string dataChoice)
lat & long are the latitude and longitude of the location you want the weather for.
dataChoice is the data you want to look up, formatted the same way as a regular url request to the rest service, for example Hourly Temperature is "temp=temp" and Maximum Temperature is "maxt=maxt".
