# 🌳 Survey-Tree (Binary Tree Navigator)

A console-based C# application designed to create, manage, and traverse a **Binary Tree**. This project provides an interactive command-line interface to dynamically build a tree structure by adding or deleting nodes and performing all three classic depth-first tree traversals (Inorder, Preorder, and Postorder).

## 📋 Table of Contents

- [Features](#-features)
- [Algorithm Details](#-algorithm-details)
- [Technologies Used](#-technologies-used)
- [Prerequisites](#-prerequisites)
- [Installation](#-installation)
- [How to Use](#-how-to-use)
- [Commands](#-commands)
- [Example Usage](#-example-usage)
- [Project Structure](#-project-structure)
- [Contributing](#-contributing)
- [License](#-license)

## ✨ Features

- **Dynamic Tree Construction**: Initialize the tree with a custom root node and build the structure interactively.
- **Node Management**: 
  - Add new nodes by specifying the parent node, the new data, and whether it should be a Left (`L`) or Right (`R`) child.
  - Delete any node from the tree. If the root is deleted, the program prompts for a new root value.
- **Parent Pointers**: Each node maintains a reference to its parent, making upward navigation and specific deletions easier.
- **Complete Traversal Suite**: Supports all three standard Depth-First Search (DFS) traversals:
  - **Inorder** (Left, Root, Right)
  - **Preorder** (Root, Left, Right)
  - **Postorder** (Left, Right, Root)
- **Interactive CLI**: A simple, menu-driven console interface for easy testing and visualization.

## 🧠 Algorithm Details

### Tree Traversals
The project implements recursive algorithms for the three primary ways to visit all nodes in a binary tree:

| Traversal Type | Order of Visiting | Use Case |
|----------------|-------------------|----------|
| **Inorder** | Left Subtree $\rightarrow$ Root $\rightarrow$ Right Subtree | In Binary Search Trees (BST), it retrieves data in sorted, non-decreasing order. |
| **Preorder** | Root $\rightarrow$ Left Subtree $\rightarrow$ Right Subtree | Useful for creating a copy of the tree or evaluating prefix expressions. |
| **Postorder** | Left Subtree $\rightarrow$ Right Subtree $\rightarrow$ Root | Commonly used for deleting the tree (children are deleted before parents) or evaluating postfix expressions. |

### Node Deletion Logic
When deleting a node, the algorithm searches the tree. Once found:
1. If it's the **Root Node** (no parent), the program asks the user to input a new value to replace the root's data.
2. If it's a **Left Child**, it sets the parent's `LChild` pointer to `null`.
3. If it's a **Right Child**, it sets the parent's `RChild` pointer to `null`.
*(Note: This implementation performs a simple structural deletion without rebalancing or reattaching subtrees).*

## 🛠 Technologies Used

| Technology | Purpose |
|------------|---------|
| C# | Programming language |
| .NET Framework | Runtime environment |
| Console Application | User interface |

## 📦 Prerequisites

Before running this project, ensure you have:

- [Visual Studio](https://visualstudio.microsoft.com/) (2019 or later) OR
- [.NET Framework](https://dotnet.microsoft.com/download) (4.0 or higher)
- Windows Operating System

## 🚀 Installation

### 1. Clone the Repository

```bash
git clone https://github.com/Kowsari1382/Survey-Tree.git
cd Survey-Tree
```

### 2. Open in Visual Studio

1. Open Visual Studio.
2. Click on **Open a project or solution**.
3. Navigate to the cloned repository and select `Navigation Project/Navigation Project.sln`.
4. Click **Open**.

### 3. Build and Run

- Press `F5` or click the **Start** button to run the application.
- Alternatively, build the project first (`Ctrl+Shift+B`) and run the executable from the `bin/Debug` folder.

## 🎮 How to Use

1. **Initialize the Tree**: When the program starts, it will ask for the data of the root node. Enter an integer.
2. **Main Menu**: You will be presented with a menu of commands (0 to 6).
3. **Add a Node**: 
   - Select `1`.
   - Enter the value of the **parent** node to which you want to attach the new node.
   - Enter the **data** for the new node.
   - Enter `L` for Left child or `R` for Right child.
4. **Delete a Node**: Select `2` and enter the data of the node you want to remove.
5. **Traverse the Tree**: Select `3` (Inorder), `4` (Postorder), or `5` (Preorder) to print the tree's data in that specific order.

## 🎯 Commands

| Command | Action |
|---------|--------|
| `0` | Exit the program. |
| `1` | Add a new node to the tree. |
| `2` | Delete a node from the tree. |
| `3` | Perform and print **Inorder** traversal. |
| `4` | Perform and print **Postorder** traversal. |
| `5` | Perform and print **Preorder** traversal. |
| `6` | Show help/instructions. |

## 🔢 Example Usage

Let's build a small tree and traverse it:

```text
input a data for your tree root:
10
input a number between 0 to 5 and if you need help,input 6:
1
input parent:
10
input data:
5
input L for left or R for right:
L
Node was added to tree.

input a number between 0 to 5 and if you need help,input 6:
1
input parent:
10
input data:
15
input L for left or R for right:
R
Node was added to tree.

input a number between 0 to 5 and if you need help,input 6:
3
inorder:
5
10
15

input a number between 0 to 5 and if you need help,input 6:
5
preorder:
10
5
15
```

## 📁 Project Structure

```text
Survey-Tree/
└── Navigation Project/
    ├── Navigation Project/
    │   ├── Properties/          # Assembly info and resources
    │   ├── bin/Debug/           # Compiled binaries
    │   ├── obj/Debug/           # Build objects
    │   ├── App.config           # Application configuration
    │   ├── Node.cs              # Node class definition (Data, LChild, RChild, Parent)
    │   ├── BinaryTree.cs        # Core logic (Add, Delete, Traversals)
    │   ├── Program.cs           # Main entry point and CLI menu
    │   └── Navigation Project.csproj # Project file
    └── Navigation Project.sln   # Solution file
```

### Key Classes

| Class/File | Description |
|------------|-------------|
| `Node.cs` | Defines the structure of a tree node, containing `data`, `LChild`, `RChild`, and `Parent` pointers. |
| `BinaryTree.cs` | Contains the recursive logic for adding nodes, deleting nodes, and performing Inorder, Preorder, and Postorder traversals. |
| `Program.cs` | Handles the user interface, taking input and calling the appropriate `BinaryTree` methods. |

## 🤝 Contributing

Contributions are welcome! If you have suggestions for improvements or new features:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/AmazingFeature`).
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`).
4. Push to the branch (`git push origin feature/AmazingFeature`).
5. Open a Pull Request.

### Ideas for Contributions

- **Level-Order Traversal**: Implement Breadth-First Search (BFS) using a Queue.
- **Visual Tree Printing**: Add a feature to print the tree structure visually in the console (e.g., using ASCII art).
- **Binary Search Tree (BST) Logic**: Modify the `AddNode` method to automatically place nodes based on BST rules (left < parent < right) without needing manual `L/R` input.
- **Advanced Deletion**: Implement proper deletion for nodes with two children (finding the inorder successor).
- **Tree Properties**: Add methods to calculate the height, depth, and check if the tree is balanced.

## 📝 License

This project is open source and available for educational purposes.

## 👨‍💻 Author

**Sajjad Kowsari**

- GitHub: [@Kowsari1382](https://github.com/Kowsari1382)

## 📞 Support

If you encounter any issues or have questions, please open an issue on GitHub.

---

<div align="center">

**Happy Navigating! 🌲**

**If you find this project useful, please consider giving it a ⭐!**

</div>
