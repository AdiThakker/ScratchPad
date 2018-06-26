using System;

namespace DataStructures.Core
{
    public class Sort
    {
        #region Bubble Sort

        public void BubbleSortArray(int[] array)
        {
            // Validate 
            if (array == null || array.Length == 0)
                throw new ArgumentNullException("Array cannot be null or length 0.");

            BubbleSort(array);
        }

        private void BubbleSort(int[] array)
        {
            // keep looping till there is a swap
            bool swap = true;
            while (swap == true)
            {
                swap = false;
                // start at index 1 and iterate
                for (int index = 1; index < array.Length; index++)
                {
                    // Compare and swap
                    if (array[index] < array[index - 1])        // {5,3}
                    {
                        Swap(array, index, index - 1);
                        swap = true;
                    }
                }
            }
        }

        private void Swap(int[] array, int from, int to)
        {
            int temp = array[from];
            array[from] = array[to];
            array[to] = temp;
        }

        #endregion

        #region Insertion Sort

        public void InsertionSortArray(int[] array)
        {
            // Validate 
            if (array == null || array.Length == 0)
                throw new ArgumentNullException("Array cannot be null or length 0.");

            InsertionSort(array);
        }

        private void InsertionSort(int[] array)
        {
            // Loop through the array once by starting at index 1 
            for (int index = 1; index < array.Length; index++)
            {
                // Compare items
                if (array[index] < array[index - 1])    // {5,3}
                {
                    // store the value in temp
                    int temp = array[index];

                    // Get the insertion Index
                    int insertionIndex = GetInsertionIndex(array, temp, 0, index); // everything before this index is sorted

                    // Slide items
                    SlideItems(array, insertionIndex, index);

                    // Save the item in the correct position
                    array[insertionIndex] = temp;
                }
            }
        }

        private int GetInsertionIndex(int[] array, int value, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                if (array[i] > value)
                    return i;
            }
            return -1; // this should not happen...
        }

        private void SlideItems(int[] array, int start, int end)
        {
            for (int i = end; i > start; i--)
            {
                array[i] = array[i - 1];
            }
        }

        #endregion

        #region Merge Sort

        public void MergeSortArray(int[] array)
        {
            // Validate
            if (array == null || array.Length == 0)
                throw new ArgumentNullException($"{nameof(array)} cannot be null.");

            int[] scratch = new int[array.Length];

            MergeSort(array, scratch, 0, array.Length - 1);
        }

        private void MergeSort(int[] array, int[] scratch, int start, int end)
        {
            // backtrack
            if (start >= end)
                return;

            // get the mid point of the array
            int mid = (start + end) / 2;

            // Recursively call MergeSort halving the arrays
            MergeSort(array, scratch, start, mid);
            MergeSort(array, scratch, mid + 1, end);

            // Start moving the appropriate items to scratch
            int leftIndex = start;
            int rightIndex = mid + 1;
            int scratchIndex = leftIndex;
            while (leftIndex <= mid && rightIndex <= end)
            {
                // Compare items
                if (array[leftIndex] <= array[rightIndex])
                {
                    scratch[scratchIndex] = array[leftIndex];
                    leftIndex++;
                }
                else
                {
                    scratch[scratchIndex] = array[rightIndex];
                    rightIndex++;
                }
                scratchIndex++;
            }

            // copy remaining items
            for (int i = leftIndex; i <= mid; i++)
            {
                scratch[scratchIndex] = array[i];
                scratchIndex++;
            }

            for (int i = rightIndex; i <= end; i++)
            {
                scratch[scratchIndex] = array[i];
                scratchIndex++;
            }

            // finally copy items from scratch to array
            for (int i = start; i <= end; i++)
            {
                array[i] = scratch[i];
            }
        }

        #endregion
    }
}
