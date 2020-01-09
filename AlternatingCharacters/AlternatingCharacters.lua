-- Complete the alternatingCharacters function below.
function alternatingCharacters(s)

    local deletion = 0;

    for i=1, #s do
        if (i ~= #s and s:sub(i,i) == s:sub(i+1, i+1)) then
            deletion = deletion + 1;
        end
    end

    return deletion
end

local fptr = io.open(os.getenv("OUTPUT_PATH"), "w")

local q = io.stdin:read("*n", "*l")

for qitr = 1, q do
    local s = io.stdin:read("*l")

    local result = alternatingCharacters(s)

    fptr:write(result, "\n")
end

fptr:close()
