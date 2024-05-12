# Name: KAYODE PETER TEMITOPE
# Matric number: 208077
# Department: Computer Science (200 Level)

    #Question 1
sequence = input("Enter the sequence: ").strip()
print("The fraction of G and C bases in the provided sequence is " + str(sequence.count("C") + sequence.count("G")) + "/" + str(len(sequence)))


    #Question 2
 # Get the required sequence from the user
seq = input("Enter the sequence: ").strip()
# Each character in [map_from] will map to the corresponding character in[map_to] based on index
# We achieve this by creating a 'mapper' using the str.maketrans method 
# We then call the translate method on sequence, making use of our mapper.
map_from = "ACGT"
map_to = "TGCA"
mapper = str.maketrans(map_from, map_to)
complement = seq.translate(mapper)

# Determine if the seq is palindrome with respect to its complement
if (seq[::-1] == complement):
    print("The provided sequence,", seq, "is a palindrome in terms of its complement")
else:
    print("This sequence,", seq, "is not a palindrome in terms of its complement")
 
