namespace TreeOfNNodes
{
    using System;
    using System.Collections.Generic;

    public class TreeNode<T>
    {
        private T value;
        private List<TreeNode<T>> children;
        private bool hasParent;

        public TreeNode(T value)
        {
            this.Value = value;
            this.children = new List<TreeNode<T>>();
        }

        public int ChildrenCount
        {
            get { return this.children.Count; }
        }

        public T Value
        {
            get
            {
                return this.value;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Value cannot be null");
                }

                this.value = value;
            }
        }

        public void AddChild(TreeNode<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException("Child cannot be null");
            }

            if (child.hasParent)
            {
                throw new ArgumentNullException("Child already has a parent");
            }

            this.children.Add(child);
        }
    }
}