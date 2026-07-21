# Git Lab 4 – Merge Conflict Resolution

## Objective

The objective of this lab is to understand how merge conflicts occur in Git and learn how to resolve them when different changes are made to the same file in different branches.

---

## Prerequisites

- Git installed on the local machine
- Git Bash
- GitLab account
- Existing Git repository from previous labs

---

## Tasks Performed

### 1. Verified Repository Status

Checked that the master branch was in a clean state before starting the lab.

```bash
git status
```

---

### 2. Created a New Branch

Created a new branch named **GitWork**.

```bash
git branch GitWork
```

Switched to the newly created branch.

```bash
git checkout GitWork
```

---

### 3. Created `hello.xml` in GitWork Branch

Created a file named `hello.xml` and added XML content.

```xml
<message>Hello from GitWork Branch</message>
<message>Jyothirmai Chapala</message>
```

Checked repository status.

```bash
git status
```

---

### 4. Added and Committed Changes

```bash
git add hello.xml
```

```bash
git commit -m "Added hello.xml in GitWork"
```

---

### 5. Switched Back to Master

```bash
git checkout master
```

---

### 6. Created the Same File with Different Content

Created `hello.xml` with different content to intentionally create a merge conflict.

```xml
<message>from Jyothirmai - Hello from Master Branch</message>
```

Added and committed the file.

```bash
git add hello.xml
```

```bash
git commit -m "Added hello.xml in master"
```

---

### 7. Viewed Commit History

Displayed the commit history of all branches.

```bash
git log --oneline --graph --decorate --all
```

---

### 8. Compared Branches

Compared the differences between the master branch and GitWork branch.

```bash
git diff master GitWork
```

---

### 9. Merged GitWork into Master

Attempted to merge the GitWork branch.

```bash
git merge GitWork
```

Git reported a merge conflict because the same file had different content in both branches.

---

### 10. Resolved the Merge Conflict

Opened `hello.xml`, removed the conflict markers, and kept the required content.

Final content:

```xml
<message>from Jyothirmai - Hello from Master Branch</message>
<message>Hello from GitWork Branch</message>
<message>Jyothirmai Chapala</message>
```

Marked the conflict as resolved.

```bash
git add hello.xml
```

Committed the merge.

```bash
git commit -m "Resolved merge conflict"
```

---

### 11. Updated `.gitignore`

Added backup files to `.gitignore`.

```text
*.bak
```

Committed the updated file.

```bash
git add .gitignore
```

```bash
git commit -m "Added backup files to .gitignore"
```

---

### 12. Listed Available Branches

```bash
git branch
```

---

### 13. Deleted the Merged Branch

```bash
git branch -d GitWork
```

---

### 14. Viewed Final Commit History

```bash
git log --oneline --graph --decorate
```

---

### 15. Pushed Changes to GitLab

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
├── branch.txt
└── hello.xml
```

---

## Commands Used

| Command | Description |
|----------|-------------|
| `git status` | Check repository status |
| `git branch GitWork` | Create a new branch |
| `git checkout GitWork` | Switch to GitWork branch |
| `git add hello.xml` | Stage the file |
| `git commit -m "Added hello.xml in GitWork"` | Commit changes in GitWork |
| `git checkout master` | Switch to master branch |
| `git commit -m "Added hello.xml in master"` | Commit changes in master |
| `git log --oneline --graph --decorate --all` | Display commit history |
| `git diff master GitWork` | Compare branches |
| `git merge GitWork` | Merge GitWork into master |
| `git add hello.xml` | Mark conflict as resolved |
| `git commit -m "Resolved merge conflict"` | Commit the resolved merge |
| `git add .gitignore` | Stage updated `.gitignore` |
| `git commit -m "Added backup files to .gitignore"` | Commit `.gitignore` changes |
| `git branch` | List branches |
| `git branch -d GitWork` | Delete merged branch |
| `git log --oneline --graph --decorate` | Display final commit history |
| `git push` | Push repository to GitLab |

---

## Output

- Successfully created a new branch named **GitWork**.
- Created different versions of the same file in separate branches.
- Generated a merge conflict during branch merging.
- Resolved the merge conflict manually.
- Updated `.gitignore` to ignore backup files.
- Deleted the merged branch.
- Successfully pushed the final repository to GitLab.

---

## Conclusion

This lab demonstrated Git's merge conflict mechanism by creating conflicting changes in two branches. The conflict was resolved manually by editing the affected file, staging the resolved version, and completing the merge commit. The lab also covered updating the `.gitignore` file, branch management, commit history visualization, and pushing the final changes to the remote GitLab repository.
