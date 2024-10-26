class Solution {

    /**
     * @param Integer[] $nums1
     * @param Integer $m
     * @param Integer[] $nums2
     * @param Integer $n
     * @return NULL
     */
    function merge(&$nums1, $m, $nums2, $n) {
        for($i = 0; $i < $n; $i++){
            $nums1[$i + $m] = $nums2[$i];
        }
        
        sort($nums1);
    }
}