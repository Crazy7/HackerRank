#URL :https://www.hackerrank.com/challenges/largest-rectangle
#Solution : http://www.geeksforgeeks.org/largest-rectangle-under-histogram/ 

def computeStack(hist, stack, max_area, idx):
    height_idx = stack.pop()
             
    depth = idx 
    if stack:
        depth = idx - stack[-1] - 1
    
    area = hist[height_idx] * depth
    max_area = max(area, max_area)

    return max_area


def computeLargestArea(hist, N):
    stack = []
     
    max_area = 0
     
    idx = 0
    while (idx < N):
        if not stack or hist[stack[-1]] <= hist[idx]:
            stack.append(idx)
            idx += 1

            print "stack : " + str(stack[-1])
        else:
             
            # height_idx = stack.pop()
             
            # depth = idx
            # if stack:
            #     depth = idx - stack[-1] - 1
             
            # area = hist[height_idx] * depth
            # max_area = max(area, max_area)
            max_area = computeStack(hist, stack, max_area, idx)
      
    while stack:
        # height_idx = stack.pop()
             
        # depth = idx
        # if stack:
        #     depth = idx - stack[-1] - 1
             
        # area = hist[height_idx] * depth
        # max_area = max(area, max_area)
        max_area = computeStack(hist, stack, max_area, idx)
             
    return max_area
 
def main():
    N = int(raw_input())
     
    hist = map(int, raw_input().split())
     
    print computeLargestArea(hist, N)
     
 
 
if __name__ == '__main__':
    main()