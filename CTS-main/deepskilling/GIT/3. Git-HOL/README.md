# Git Lab 3 – Branching and Merging

## Objective

The objective of this lab is to understand Git branching and merging by creating a new branch, making changes in it, merging those changes into the master branch, and deleting the branch after a successful merge.

---

## Prerequisites

- Git installed
- Git Bash
- GitLab account
- Existing local Git repository

---

## Tasks Performed

### 1. Open the Existing Repository

Navigated to the existing Git repository.

```bash
cd ~/OneDrive/Desktop/GitDemo1
```

---

### 2. Create a New Branch

Created a new branch named **GitNewBranch**.

```bash
git branch GitNewBranch
```

---

### 3. View Available Branches

Displayed all local branches.

```bash
git branch
```

Displayed local and remote branches.

```bash
git branch -a
```

---

### 4. Switch to the New Branch

Moved to the newly created branch.

```bash
git checkout GitNewBranch
```

---

### 5. Create a New File

Created a new file named **branch.txt**.

```bash
echo "This file belongs to GitNewBranch" > branch.txt
```

---

### 6. Verify Repository Status

Checked the repository status.

```bash
git status
```

---

### 7. Add the File

Added the file to the staging area.

```bash
git add branch.txt
```

---

### 8. Commit the Changes

Committed the changes.

```bash
git commit -m "Added branch.txt in GitNewBranch"
```

---

### 9. Switch Back to Master

Moved back to the master branch.

```bash
git checkout master
```

---

### 10. Compare Branches

Compared the differences between the master branch and GitNewBranch.

```bash
git diff master GitNewBranch
```

---

### 11. Merge the Branch

Merged **GitNewBranch** into the master branch.

```bash
git merge GitNewBranch
```

---

### 12. View Commit History

Displayed the commit history in graph format.

```bash
git log --oneline --graph --decorate
```

---

### 13. Delete the Branch

Deleted the merged branch.

```bash
git branch -d GitNewBranch
```

---

### 14. Push Changes to GitLab

Uploaded the latest changes to the remote repository.

```bash
git push
```

---

## Repository Structure

```
GitDemo1
│
├── .gitignore
├── README.md
├── welcome.txt
└── branch.txt
```

---

## Commands Used

| Command | Description |
|----------|-------------|
| `git branch GitNewBranch` | Create a new branch |
| `git branch` | Display local branches |
| `git branch -a` | Display local and remote branches |
| `git checkout GitNewBranch` | Switch to the new branch |
| `git status` | Check repository status |
| `git add branch.txt` | Stage the new file |
| `git commit -m "Added branch.txt in GitNewBranch"` | Commit changes |
| `git checkout master` | Switch to the master branch |
| `git diff master GitNewBranch` | Compare branches |
| `git merge GitNewBranch` | Merge branch into master |
| `git log --oneline --graph --decorate` | Display commit history |
| `git branch -d GitNewBranch` | Delete merged branch |
| `git push` | Push changes to GitLab |

---

## Output

- Successfully created a new branch named **GitNewBranch**.
- Added a new file named **branch.txt**.
- Committed the changes to the branch.
- Merged the branch into the **master** branch.
- Viewed the commit history using Git log.
- Deleted the feature branch after a successful merge.
- Pushed the updated repository to GitLab.

---

## Conclusion

This lab demonstrated how to create a new Git branch, work independently on that branch, merge changes into the master branch, inspect the commit history, and safely delete the merged branch. It illustrates the basic Git workflow used in collaborative software development.
