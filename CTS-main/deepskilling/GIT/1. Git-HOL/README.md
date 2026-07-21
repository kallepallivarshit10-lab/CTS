

# Git Lab 1 – Git Configuration and Basic Git Commands

## Objective

This lab demonstrates the basic Git workflow by configuring Git, creating a local repository, tracking files, committing changes, and synchronizing the repository with a remote GitLab repository.

## Prerequisites

- Git installed
- Git Bash
- GitLab account
- Internet connection

## Tasks Performed

### 1. Configure Git

Configured the global username and email.

```bash
git config --global user.name "Jyothirmai Chapala"
git config --global user.email "jyothi.chapala.2006@gmail.com"
```

Verified the configuration.

```bash
git config --global --list
```

---

### 2. Create a Local Git Repository

Created a project folder and initialized Git.

```bash
mkdir GitDemo1
cd GitDemo1
git init
```

---

### 3. Create a File

Created a text file named `welcome.txt`.

```bash
echo "Welcome to Git Lab" > welcome.txt
```

Verified the file.

```bash
cat welcome.txt
```

---

### 4. Check Repository Status

Checked the repository status.

```bash
git status
```

---

### 5. Stage the File

Added the file to the staging area.

```bash
git add welcome.txt
```

---

### 6. Commit the Changes

Created the first commit.

```bash
git commit -m "Initial Commit"
```

---

### 7. Connect to GitLab

Added the remote repository.

```bash
git remote add origin <GitLab Repository URL>
```

Pulled the remote repository.

```bash
git pull origin main --allow-unrelated-histories
```

Pushed the local repository.

```bash
git push -u origin master
```

---

## Repository Structure

```
GitDemo1
│
├── welcome.txt
└── .git
```

---

## Commands Used

| Command | Description |
|----------|-------------|
| git init | Initialize a Git repository |
| git status | View repository status |
| git add | Stage files for commit |
| git commit | Save changes to the repository |
| git remote add | Connect local repository to remote |
| git pull | Download changes from remote |
| git push | Upload local commits to remote |
| git config | Configure Git username and email |

---

## Output

- Git successfully configured.
- Local repository created.
- `welcome.txt` added and committed.
- Repository connected to GitLab.
- Local repository pushed to the remote repository successfully.

---

## Conclusion

This lab introduced the fundamental Git workflow, including repository initialization, file tracking, committing changes, and synchronizing a local repository with a remote GitLab repository.
