import requests
import json
import time

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
	print(f"The current gust of wind is {gust_kph}km/h")
	print(f"The current wind direction is {wind_dir}º")
	print(f"The current precipitation is {precip_mm} mm")
	print(f"The current humidity is {humidity}%")
	print(f"The current visibility is {vis_km}km\n")

def get_forecast_day1():
		## API ##  ## API ##  ## API ##
	url = "https://weatherapi-com.p.rapidapi.com/forecast.json"
	querystring = {"q":{city},"days":"3"}
	headers = {
	"X-RapidAPI-Key": "d78e25739emsh1ebb038d6fdff39p1ee51fjsn3c022600587c",
	"X-RapidAPI-Host": "weatherapi-com.p.rapidapi.com"
				}
	response = requests.get(url, headers=headers, params=querystring)
	res = response.json()
		## API ##  ## API ##  ## API ##

	###DATA###
	#location
	region = res["location"]["name"]
	country = res["location"]["country"]
	#forecast day 1
	last_updated = res["current"]["last_updated"]
	forecast_date = res["forecast"]["forecastday"][1]["date"]
	min_temp_c = res["forecast"]["forecastday"][1]["day"]["mintemp_c"]
	max_temp_c = res["forecast"]["forecastday"][1]["day"]["maxtemp_c"]
	avg_temp_c = res["forecast"]["forecastday"][1]["day"]["avgtemp_c"]
	max_wind_kph = res["forecast"]["forecastday"][1]["day"]["maxwind_kph"]
	totalprecip_mm = res["forecast"]["forecastday"][1]["day"]["totalprecip_mm"]
	avgvis_km = res["forecast"]["forecastday"][1]["day"]["avgvis_km"]
	avg_humidity = res["forecast"]["forecastday"][1]["day"]["avghumidity"]
	chance_of_rain = res["forecast"]["forecastday"][1]["day"]["daily_chance_of_rain"]
	chance_of_snow = res["forecast"]["forecastday"][1]["day"]["daily_chance_of_snow"]
	condition = res["forecast"]["forecastday"][1]["day"]["condition"]["text"]

	#PRINTS

	print(f"\nThe following forecast is from {region}, {country}")
	print(f"The following data was last update at {last_updated}")
	print(f"The following data is for tomorrow, {forecast_date}\n")
	print(f"The average temperature for tomorrow is {avg_temp_c}ºC")
	print(f"The minimum temperature for tomorrow is {min_temp_c}ºC")
	print(f"The max temperature for tomorrow is {max_temp_c}ºC")
	print(f"The condition for tomorrow is '{condition}'")
	print(f"The max wind speed for tomorrow is {max_wind_kph}km/h")
	print(f"The total precipitation for tomorrow is {totalprecip_mm}mm")
	print(f"The chance of rain for tomorrow is {chance_of_rain}%")
	print(f"The chance of snow for tomorrow is {chance_of_snow}%")
	print(f"The average humidity for tomorrow is {avg_humidity}%")
	print(f"The average visibility for tomorrow is {avgvis_km}km\n")

def get_forecast_day2():
	## API ##  ## API ##  ## API ##
	url = "https://weatherapi-com.p.rapidapi.com/forecast.json"
	querystring = {"q":{city},"days":"3"}
	headers = {
	"X-RapidAPI-Key": "d78e25739emsh1ebb038d6fdff39p1ee51fjsn3c022600587c",
	"X-RapidAPI-Host": "weatherapi-com.p.rapidapi.com"
				}
	response = requests.get(url, headers=headers, params=querystring)
	res = response.json()
		## API ##  ## API ##  ## API ##

	###DATA###
	#location
	region = res["location"]["name"]
	country = res["location"]["country"]
	#forecast day 2

	last_updated = res["current"]["last_updated"]
	forecast_date = res["forecast"]["forecastday"][2]["date"]
	min_temp_c = res["forecast"]["forecastday"][2]["day"]["mintemp_c"]
	max_temp_c = res["forecast"]["forecastday"][2]["day"]["maxtemp_c"]
	avg_temp_c = res["forecast"]["forecastday"][2]["day"]["avgtemp_c"]
	max_wind_kph = res["forecast"]["forecastday"][2]["day"]["maxwind_kph"]
	totalprecip_mm = res["forecast"]["forecastday"][2]["day"]["totalprecip_mm"]
	avgvis_km = res["forecast"]["forecastday"][2]["day"]["avgvis_km"]
	avg_humidity = res["forecast"]["forecastday"][2]["day"]["avghumidity"]
	chance_of_rain = res["forecast"]["forecastday"][2]["day"]["daily_chance_of_rain"]
	chance_of_snow = res["forecast"]["forecastday"][2]["day"]["daily_chance_of_snow"]
	condition = res["forecast"]["forecastday"][2]["day"]["condition"]["text"]

	#PRINTS

	print(f"\nThe following forecast is from {region}, {country}")
	print(f"The following data was last update at {last_updated}")
	print(f"The following data is for the day after tomorrow,{forecast_date}\n")
	print(f"The average temperature for {forecast_date} is {avg_temp_c}ºC")
	print(f"The minimum temperature for {forecast_date} is {min_temp_c}ºC")
	print(f"The max temperature for {forecast_date} is {max_temp_c}ºC")
	print(f"The condition for {forecast_date} is '{condition}'")
	print(f"The max wind speed for {forecast_date} is {max_wind_kph}km/h")
	print(f"The total precipitation for {forecast_date} is {totalprecip_mm}mm")
	print(f"The chance of rain for {forecast_date} is {chance_of_rain}%")
	print(f"The chance of snow for {forecast_date} is {chance_of_snow}%")
	print(f"The average humidity for {forecast_date} is {avg_humidity}%")
	print(f"The average visibility for {forecast_date} is {avgvis_km}km\n")

while True:
	### MENU ###
	print("""
#######################################
### Welcome to the Weather Station! ###
#######################################\n""")

	print("1 - Choose a city.")
	print("2 - Check current weather.")
	print("3 - Check forecast for tomorrow.")
	print("4 - Check forecast for after tomorrow.")
	print("5 - Exit.")
	question = input("Choose an option -> ")

	match(question):
		case "1":
			city = input("Whats the city?\n")
			print(f"{city} was defined as the city.\n")
		case "2":
			print("______________________CURRENT_WEATHER______________________")
			get_current_weather()
			print("___________________________________________________________") 
		case "3":
			print("___________________________________________________________") ## ADICIONAR DATA C/ GLOBAL VARIABLE
			get_forecast_day1()
			print("___________________________________________________________")
		case "4":
			print("___________________________________________________________") ## ADICIONAR DATA C/ GLOBAL VARIABLE
			get_forecast_day2()
			print("___________________________________________________________")
		case "5":
			print("\nLeaving the Weather Station.")
			time.sleep(0.8)
			print("Leaving the Weather Station..")
			time.sleep(0.8)
			print("Leaving the Weather Station...\n")
			time.sleep(0.5)
			break
		case _:
			print("That's not an option.")
