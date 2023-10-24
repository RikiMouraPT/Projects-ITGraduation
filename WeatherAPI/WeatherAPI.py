import requests
import json

url = "https://weatherapi-com.p.rapidapi.com/forecast.json"


#city = input("Whats the city? ")
#querystring = {"q":{city},"days":"3"}

#headers = {
#	"X-RapidAPI-Key": "d78e25739emsh1ebb038d6fdff39p1ee51fjsn3c022600587c",
#	"X-RapidAPI-Host": "weatherapi-com.p.rapidapi.com"
#}
#response = requests.get(url, headers=headers, params=querystring)
#res = response.json()

def get_current_weather():
		## API ##

	url = "https://weatherapi-com.p.rapidapi.com/forecast.json"
	querystring = {"q":{city},"days":"3"}
	headers = {
	"X-RapidAPI-Key": "d78e25739emsh1ebb038d6fdff39p1ee51fjsn3c022600587c",
	"X-RapidAPI-Host": "weatherapi-com.p.rapidapi.com"
				}
	
	response = requests.get(url, headers=headers, params=querystring)
	res = response.json()
	#location
	region = res["location"]["name"]
	country = res["location"]["country"]
	#current
	last_updated = res["current"]["last_updated"]
	temp_c = res["current"]["temp_c"]
	feelslike_c = res["current"]["feelslike_c"]
	condition = res["current"]["condition"]["text"]
	wind_kph = res["current"]["wind_kph"]
	gust_kph = res["current"]["gust_kph"]
	wind_dir = res["current"]["wind_dir"]
	precip_mm = res["current"]["precip_mm"]
	humidity = res["current"]["humidity"]
	vis_km = res["current"]["vis_km"]
	#PRINTS

	print(f"\nThe following data is from {region}, {country}")
	print(f"The following data was last update at {last_updated}\n")
	print(f"The current temperature is {temp_c}ºC")
	print(f"The current feelslike temperature is {feelslike_c}ºC")
	print(f"The current condition is '{condition}'")
	print(f"The current wind is {wind_kph}km/h")
	print(f"The current gust of wind is {wind_kph}km/h")
	print(f"The current wind direction is {wind_kph}")
	print(f"The current precipitation is {precip_mm} mm")
	print(f"The current humidity is {humidity}%")
	print(f"The current visibility is {vis_km}km\n")

def get_forecast_day1():
	forescast = str
	#forecast1 = res["forecast"]["forecastday"][1]["date"]

	#FORECAST_Prints
	#print(f"The forecast for tomorrow is:{forecast1}")

while True:
	### API ###
	city = str
	url = "https://weatherapi-com.p.rapidapi.com/forecast.json"
	querystring = {"q":{city},"days":"3"}
	headers = {
	"X-RapidAPI-Key": "d78e25739emsh1ebb038d6fdff39p1ee51fjsn3c022600587c",
	"X-RapidAPI-Host": "weatherapi-com.p.rapidapi.com"
				}
	response = requests.get(url, headers=headers, params=querystring)
	res = response.json()
	
	### MENU ###
	print("Welcome to the Weather Station!\n")
	print("1 - Choose a city.")
	print("2 - Check current weather.")
	print("3 - Check forecast for tomorrow.(NOT DONE)")
	print("4 - Check forecast for after tomorrow.(NOT DONE)")
	print("5 - Exit.")
	question = input("Choose an option -> ")

	match(question):
		case "1":
			city = input("Whats the city?\n")
			print(f"{city} was defined as the city.\n")
		case "2":
			get_current_weather()
		case "5":
			break
		case _:
			print("That's not an option.")