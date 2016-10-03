# URL : https://www.hackerrank.com/challenges/poisonous-plants
# https://www.martinkysel.com/hackerrank-poisonous-plants-solution/

class Plant:
    def __init__(self, pesticide, days):
        self.pesticide = pesticide
        self.days = days
 
def solvePlants(a):
    stack = []
    maxDaysAlive = 0
     
    for pesticide in a:
        daysAlive = 0
        while stack and pesticide <= stack[-1].pesticide:
            daysAlive = max(daysAlive, stack.pop().days)
             
        if not stack:
            daysAlive = 0
        else:
            daysAlive += 1
             
        maxDaysAlive = max(maxDaysAlive, daysAlive)
         
        stack.append(Plant(pesticide, daysAlive))
     
    print maxDaysAlive
 
def main():
    N = input()
      
    numbers = map(int, raw_input().split())
      
    solvePlants(numbers)
      
  
if __name__ == '__main__':
    main()