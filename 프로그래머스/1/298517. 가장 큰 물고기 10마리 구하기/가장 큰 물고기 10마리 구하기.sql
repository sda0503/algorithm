-- 코드를 작성해주세요

select ID,LENGTH from FISH_INFO 
ORDER BY IFNULL(LENGTH,10) DESC, ID
Limit 10
