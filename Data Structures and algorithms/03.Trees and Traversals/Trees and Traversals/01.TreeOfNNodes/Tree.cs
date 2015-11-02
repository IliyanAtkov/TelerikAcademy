namespace TreeOfNNodes
{
    using System;
    using System.Collections.Generic;

    public class Tree<T>
    {
        private TreeNode<T> root;

        public Tree(T value)
        {
            this.Root = new TreeNode<T>(value);
        }

        public Tree(T value, params Tree<T>[] children)
            :this(value)
        {
            foreach (var child in children)
            {
                this.Root.AddChild(child.Root);
            }
        }

        public TreeNode<T> Root
        {
            get
            {
                return this.root;
            }
            private set
            {
                if (value.Value == null)
                {
                    throw new ArgumentNullException("Value cannot be null");
                }

                this.root = value;
            }          
        }
    }
}