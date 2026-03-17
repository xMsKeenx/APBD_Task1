# APBD Task 1

## 1. When does Git perform a fast-forward and when is a merge commit created?
Fast-forward happens when the main branch has no new commits, so Git just moves it forward to match the feature branch. A merge commit is created when both branches have changes and Git needs to combine them.

## 2. What is the practical difference between merge and rebase?
Merge keeps the full history with branches and adds a merge commit. Rebase moves commits on top of another branch, so the history looks clean and straight.

## 3. How was the conflict resolved in your repository?
The conflict happened because the same line in Program.cs was changed differently in two branches. I fixed it manually by choosing the final version of the line and then completed the merge in Visual Studio.