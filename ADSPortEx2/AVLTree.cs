using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx2
{
    //AVL Tree implementation for Assessed Exercise 2

    //Hints : 
    //Use lecture materials from Week 6A
    // and lab sheet 'Lab 6: AVL Trees' to aid with implementation...

    //You may need to adjust your other tree classes to allow your AVL tree
    // access to certain attributes and functions

    class AVLTree<T> : BSTree<T> where T : IComparable
    {

        //Functions for EX.2C
        public new void InsertItem(T item)
        {
            root = InsertAVL(root, item);
        }

        private Node<T> InsertAVL(Node<T> tree, T item)
        {
            if (tree == null)
                return new Node<T>(item);

            if (item.CompareTo(tree.Data) < 0)
                tree.Left = InsertAVL(tree.Left, item);
            else if (item.CompareTo(tree.Data) > 0)
                tree.Right = InsertAVL(tree.Right, item);
            else
                return tree; // duplicate title ignored

            return Balance(tree);
        }

        public new void RemoveItem(T item)
        {
            throw new NotImplementedException();
        }

        //Free space, use as required






    }// End of class
}
