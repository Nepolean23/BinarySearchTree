using BinarySearch;
using BinarySearchTree;

//UC_1_AbiltyToCreateBST_AddingNumbers<int> BST1 = new UC_1_AbiltyToCreateBST_AddingNumbers<int>(56);
//BST1.Insert(30);
//BST1.Insert(70);

//UC_2_AbilityToCreateBST_CheckingSize<int> BST2 = new UC_2_AbilityToCreateBST_CheckingSize<int>(56);
//BST2.Insert(30);
//BST2.Insert(70);
//BST2.Display();

UC_3_AbilityToCreateBST_Search<int> BST3 = new UC_3_AbilityToCreateBST_Search<int>(56);
BST3.Insert(30);
BST3.Insert(70);
BST3.Insert(63);
BST3.Display();
bool result = BST3.IfExists(63,BST3 );
Console.WriteLine(result);
Console.ReadKey();