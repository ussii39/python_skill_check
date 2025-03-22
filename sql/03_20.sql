-- さくらがフォローしているユーザーの名前を一覧で表示せよ。
SELECT u2.name FROM users u2 INNER JOIN  
(SELECT * FROM follows f INNER JOIN users u ON u.id = f.follower_id
WHERE  name = "さくら") AS temp
ON temp.followee_id = u2.id;

-- 誰もフォローしていないユーザーの名前を表示せよ。
  
SELECT name FROM users u LEFT OUTER JOIN follows f ON u.id= f.follower_id
WHERE f.followee_id is NULL