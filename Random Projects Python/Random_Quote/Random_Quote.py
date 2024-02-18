import quotes
import random
# print(all_quotes[0]["author"])
# print(all_quotes[0]["quote"])

num = random.randrange(0,46)
print(quotes.all_quotes[num]["quote"], end="\n --")
print(quotes.all_quotes[num]["author"])