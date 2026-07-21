# Git Lab 2 – Using .gitignore

## Objective

The objective of this lab is to understand the purpose of the `.gitignore` file and learn how to ignore unwanted files and folders from being tracked by Git.

---

## Prerequisites

- Git installed
- Git Bash
- Existing Git repository
- GitLab account

---

## Tasks Performed

### 1. Open Existing Git Repository

Moved to the existing Git repository.

```bash
cd ~/OneDrive/Desktop/GitDemo1
```

---

### 2. Create a Log File

Created a log file.

```bash
touch error.log
```

---

### 3. Create a Log Folder

Created a folder named `log` and a sample file inside it.

```bash
mkdir log
touch log/sample.txt
```

---

### 4. Verify Git Status

Checked the repository status.

```bash
git status
```

Git displayed the newly created `error.log` file and `log` folder as untracked files.

---

### 5. Create .gitignore

Created a `.gitignore` file.

```bash
touch .gitignore
```

Added the following rules:

```text
*.log
log/
```

These rules ignore:

- All files with `.log` extension
- The `log` folder

---

### 6. Verify Ignore Rules

Executed:

```bash
git status
```

Git no longer displayed `error.log` and `log/`, confirming that the ignore rules were working correctly.

---

### 7. Commit the Changes

Added `.gitignore` to staging.

```bash
git add .gitignore
```

Committed the changes.

```bash
git commit -m "Added .gitignore"
```

---

### 8. Push to Remote Repository

Uploaded the changes to GitLab.

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
├── error.log        (Ignored)
└── log/             (Ignored)
    └── sample.txt
```

---

## Commands Used

| Command | Description |
|----------|-------------|
| `touch error.log` | Create a log file |
| `mkdir log` | Create a folder |
| `touch log/sample.txt` | Create a file inside the folder |
| `git status` | View repository status |
| `touch .gitignore` | Create `.gitignore` file |
| `git add .gitignore` | Stage the ignore file |
| `git commit` | Commit the changes |
| `git push` | Push changes to GitLab |

---

## Output

- Created `.gitignore`.
- Ignored `.log` files and the `log` folder.
- Successfully committed and pushed the changes.
- Verified that ignored files do not appear in `git status`.

---

## Conclusion

This lab demonstrated how to use the `.gitignore` file to prevent unnecessary files and folders from being tracked by Git, helping keep the repository clean and organized.
