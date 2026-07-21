# Git Lab 5 – Clean Up and Push to Remote Repository

## Objective

The objective of this lab is to understand how to clean up a local Git repository, synchronize it with the remote repository, and push the latest changes to GitLab.

---

## Prerequisites

Before performing this lab, ensure that:

- Git is installed and configured.
- Git Bash is available.
- A GitLab account has been created.
- A local Git repository already exists.
- Previous Git hands-on labs have been completed.

---

## Tasks Performed

### 1. Verified Repository Status

Checked whether the local repository was in a clean state.

```bash
git status
```

**Output**

```
On branch master
nothing to commit, working tree clean
```

---

### 2. Listed Available Branches

Displayed all local branches.

```bash
git branch
```

**Output**

```
* master
```

---

### 3. Pulled Latest Changes from the Remote Repository

Updated the local repository with the latest changes from GitLab.

```bash
git pull origin main
```

**Output**

```
Updating ...
Fast-forward
```

---

### 4. Verified Repository Status Again

Confirmed that the repository remained clean after pulling.

```bash
git status
```

**Output**

```
On branch master
Your branch is ahead of 'origin/master' by 4 commits.

nothing to commit, working tree clean
```

---

### 5. Pushed Local Changes to the Remote Repository

Uploaded the latest local commits to GitLab.

```bash
git push
```

**Output**

```
To https://gitlab.com/...
master -> master
```

---

### 6. Verified Remote Repository

Opened the GitLab repository and confirmed that all recent commits and project files were successfully uploaded.

---

## Commands Used

```bash
cd ~/OneDrive/Desktop/GitDemo1

git status

git branch

git pull origin main

git status

git push
```

---

## Learning Outcomes

After completing this lab, I was able to:

- Verify the status of a Git repository.
- List all available branches.
- Pull the latest changes from a remote repository.
- Push local commits to the remote repository.
- Synchronize the local and remote repositories successfully.

---

## Conclusion

This lab demonstrated the final synchronization process between the local and remote Git repositories. The repository was verified to be in a clean state, updated with the latest changes from the remote repository, and all pending commits were successfully pushed to GitLab.
