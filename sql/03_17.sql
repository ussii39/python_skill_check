WITH FirstLogin AS (
    -- 各プレイヤーの最初のログイン日を取得
    SELECT player_id, MIN(event_date) AS first_login_date
    FROM Activity
    GROUP BY player_id
),
NextDayLogin AS (
    -- 各プレイヤーの最初のログイン日から次の日にログインしたかを確認
    SELECT a.player_id
    FROM Activity a
    JOIN FirstLogin f ON a.player_id = f.player_id
    WHERE DATEDIFF(a.event_date, f.first_login_date) = 1
    GROUP BY a.player_id
)
SELECT 
    ROUND(COUNT(DISTINCT n.player_id) / (SELECT COUNT(DISTINCT player_id) FROM Activity), 2) AS fraction
FROM NextDayLogin n;