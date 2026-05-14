# Week 02

## Characteristics of an Algorithm

An algorithm must have:

- **Input** — receives well-defined data
- **Output** — produces a specific result
- **Definiteness** — each step is unambiguous
- **Finiteness** — terminates after finite steps

---

## Big-O Notation

Big-O classifies how algorithms scale as input size increases.

---

## Search Algorithms

### Linear Search
- Brute force search
- Checks each item one by one
- Worst case: `O(n)`

### Binary Search
- More efficient than linear search
- Requires sorted arrays
- Splits data in half repeatedly
- Complexity: `O(log n)`

---

## Sorting Algorithms

### Bubble Sort
- Compares every pair
- Complexity: `O(n²)`

### Merge Sort
- Divide and conquer
- Complexity: `O(n log n)`

### Quick Sort
- Efficient partitioning algorithm

---

## Pseudocode

- Language independent
- Easier to communicate
- Focuses on logic instead of syntax

---

## NP-Complete Problems

NP-complete = **Nondeterministic Polynomial Complete**

---

## Data Structures

### Array
- Fast index access
- Access: `O(1)`

### Linked List
- Fast insertion: `O(1)`
- Slower index access

### Binary Search Tree
- Combines ideas of arrays and linked lists
- Efficient searching

### Hash Table
- Near-instant lookup
- Average lookup: `O(1)`

---

## Stack (LIFO)

**Last In, First Out**

Applications:
- Browser back button
- Undo functionality

---

## Queue (FIFO)

**First In, First Out**

Applications:
- Print job scheduling
- CPU task management

---

## Recursion

### Recursive
- Function calls itself
- Fibonacci example
- May run out of memory

### Iterative
- More code
- Linear complexity: `O(n)`

---

## Cache

Stores calculated results to avoid repeated computation.

---

## Algorithm Design Approaches

### Greedy
- Make locally optimal choices

### Dynamic Programming
- Store subproblem results using cache

### Backtracking
- Try options and undo if stuck

---

## Validating Correctness

- Test edge cases
- Verify known examples
- Check boundary conditions
- Measure large dataset performance

---

## Implementation Tips

- Design in pseudocode first
- Analyse complexity before coding
- Choose suitable data structures
- Profile bottlenecks

---

Algorithms shape what is possible in computing.

---

# Week 03

## Algorithm Complexity Analysis

Goal:
- Understand how input size `n` scales

### Input Size Examples

| Structure | Input Size |
|---|---|
| Array | Number of elements |
| String | Length |
| Graph | Vertices |
| Integer | Number of bits |

---

## Why Count Steps Instead of Seconds?

Because:
- CPU speeds vary
- Compiler optimizations differ
- Background processes affect timing

We need machine-independent measurements.

---

## Loop Analysis

### Single Loop
If runtime depends on `n`, growth scales with `n`.

### Binary Search
Example of logarithmic growth.

### Constant Growth
Execution time stays the same as input increases.

### Cubic Growth
Execution time increases rapidly as input grows.

---

## Complexity Cases

### Best Case
Minimum operations required.

### Worst Case
Maximum operations required.

Used for reliability analysis.

### Average Case
Expected operations for typical input.

---

## Linear Search Analysis

| Case | Comparisons |
|---|---|
| Best | 1 |
| Worst | n |

---

## Big-O Rules

- Keep dominant term only
- Ignore constants and lower-order terms
- Provides upper runtime bound

Example:

$begin:math:display$
3n \\rightarrow O\(n\)
$end:math:display$

---

## Binary Tree
Used in binary search structures.

## Hash Index
Allows direct lookup.

---

## Social Media Feed Example

### Naïve Approach
- Sort all posts
- `O(n \log n)`

### Optimised Approach
- Sort top `k` candidates
- `O(k \log k)`

Pre-filtering reduces work.

---

## Empirical vs Theoretical Analysis

### Empirical
- Measure real performance
- Count operations

### Theoretical
- Mathematical analysis using Big-O

Usually:
1. Theoretical first
2. Empirical second

Large inputs better reveal scalability differences.

---

# Week 04 — Linear Data Structures

## Choosing Data Structures

Important factors:
- Memory efficiency
- Access speed
- Modification speed

---

## Arrays

- Cache-friendly
- Fast access
- Slow modification due to shifting
- Shifting complexity: `O(n)`

---

## Linked Lists

- Nodes scattered in memory
- Connected using pointers
- Dynamic size

---

## Arrays vs Linked Lists

| Feature | Better Choice |
|---|---|
| Cache performance | Arrays |
| Insertion flexibility | Linked Lists |
| Memory efficiency | Arrays |
| Modification flexibility | Linked Lists |

Choose based on access vs modification needs.

---

## Stack

**LIFO — Last In, First Out**

- Operations: `O(1)`
- Only top element accessible

---

## Queue

### Operations
- Enqueue → add to rear
- Dequeue → remove from front

### Characteristics
- First come, first served
- Prevents unfair cutting in line
- Operations: `O(1)`

### Applications
- Printer queues
- Task scheduling

---

## Circular Queue

Rear wraps around when space becomes available.

---

## Hash Tables

- Key-value storage
- Uses computed indices

### Hash Function

$begin:math:display$
\\text\{Key\} \\rightarrow \\text\{Array Index\}
$end:math:display$

### Advantages
- Trades space for speed
- Average lookup: `O(1)`
- Faster than `O(n)` searching

### Good Hash Functions
- Distribute keys evenly
- Prevent collisions and clustering

---

## Collisions

Occurs when two keys hash to the same index.

### Linear Probing
Checks next available slot sequentially.

### Example

$begin:math:display$
\\text\{student\\\_id\} \\rightarrow \\text\{record location\}
$end:math:display$

---

## Load Factor

$begin:math:display$
\\text\{Load Factor\} \= \\frac\{\\text\{elements\}\}\{\\text\{table size\}\}
$end:math:display$

### Low Load (< 0.7)
- Few collisions
- Faster

### High Load (> 0.9)
- More collisions
- Slower

---

## Queue Implementation Guidance

Track:
- Front index
- Rear index
- Enqueue/dequeue operations
- Circular behaviour

---

## Stack Implementation Guidance

### Array-Based Stack
Uses arrays for stack operations.

---

## Quick Sort

### Partitioning
Elements left of pivot do not need full ordering initially.

### Choosing a Pivot
1. Identify first, middle, and last elements
2. Sort the 3 elements
3. Hide pivot before partitioning

# Week 05 — Sorting Algorithms

## Insertion Sort

### Idea
Take an element from the unsorted section and move it into the correct position in the sorted section.

### Process
- Shift larger numbers to the right
- Use a temporary variable to store the value being sorted
- Update values in the array as elements shift

### Steps
1. Move to the next element in the unsorted part
2. Compare it with elements in the sorted part
3. Insert it into the correct position

---

## Selection Sort

### Idea
Find the minimum value and swap it into the correct position.

### Process
- Find the smallest value in the array
- Track the minimum index
- Store the minimum value temporarily
- Swap it with the larger value

### Analogy
Like organizing books by height on a shelf.

### Key Characteristic
- Always scans the entire remaining array

---

## Bubble Sort

### Idea
At each pass, the largest value moves to the end.

### Process
- Compare adjacent elements
- Swap elements when needed
- Let the “bubble” rise to the top each round

### Key Characteristic
- Uses swapping only

---

## Merge Sort

### Idea
Uses divide and conquer.

### Process
1. Divide the list into smaller sublists
2. Continue splitting recursively
3. Sort each sublist independently
4. Merge sorted halves together efficiently

### Key Characteristics
- Recursive algorithm
- Splits the problem in half repeatedly
- Combines sorted results during merging
  
# Week 06

## Big-O Complexity

- When evaluating Big-O complexity, always analyse the **worst-case scenario**

- Worst-case analysis shows how an algorithm behaves under the hardest conditions

---

## Quick Sort

### Pivot Choice

- Pivot selection determines the performance of quicksort

- Good pivot choices improve efficiency

- Poor pivot choices can reduce performance significantly

---

## Stable Algorithms

A stable algorithm:

- Does not reorder duplicate values

---

## Merge Sort

### Characteristics

- Stable sorting algorithm

- Requires additional memory

---

## Randomized Algorithms

### Purpose

- Help avoid bad behaviour

- Reduce chances of poor worst-case performance

---

# Week 08 — Dynamic Programming

## Dynamic Programming
Dynamic programming is the process of optimizing recursive problems that have overlapping subproblems.

It is important to define what the subproblems are before anything else.

Dynamic programming is a kind of divide and conquer.

---

# Overlapping Subproblems

## Subproblem
When a problem is solved by solving smaller versions of the same problem, the smaller problem is called the **subproblem**.

### Fibonacci Example
In the case of Fibonacci numbers, `fib(n-1)` and `fib(n-2)` call many of the same functions as each other, which is what **overlapping subproblems** are all about.

One of the two techniques used to solve overlapping subproblems is **memoization**.

---

# Techniques for Solving Overlapping Subproblems

## 1. Memoization (Top-Down)

### Definition
Memoization reduces recursive calls in cases of overlapping subproblems by remembering previously computed functions.

Start at the problem you want to solve, then solve subproblems as required.

### Advantages
- Stores computed recursive calls in a hash table to avoid recomputation.
- The hash table is passed as the second parameter to functions so they can access stored values.

### Disadvantages
- Memory hungry because of:
  - the call stack
  - the memo table

---

## 2. Bottom-Up

### Definition
- Analyse the problem to determine:
  - which subproblems need to be solved
  - the order in which they should be solved
- Solve subproblems in the required order, building up to the solution of the overall problem.

### Advantages
- Uses loops instead of recursion.
- Faster and uses less memory in many cases.
- Ditches recursion and uses another approach (such as loops) to solve the same problem.

### Disadvantages
- May solve problems that are not required.
- Requires more detailed analysis during design.
---

# Sunday Algorithm

## Key Ideas

- `j` represents what we are searching for

- Initial move is:

$begin:math:display$

j \+ 1

$end:math:display$

- Movement depends on:

$begin:math:display$

j \- i

$end:math:display$

- The algorithm uses a dictionary for comparisons

---

## Process

1. Compare the first character

2. Compare the last character

3. Check whether the character exists in the dictionary

4. Subtract its index from `j` to determine movement

---

## Characteristics

- Very efficient string searching algorithm

---
