# Python OnLineGDB : https://onlinegdb.com/72ZYAcNht 
print("=== ОБИЧНА FLOATING-POINT АРИТМЕТИКА (IEEE 754) ===")
print(0.1 + 0.2)    # 0.30000000000000004
print(0.3 / 0.1)    # 2.9999999999999996
print(9007199254740993.0 - 9007199254740992.0)  # 0.0

print("=== ТАЧНА ДЕЦИМАЛНА АРИТМЕТИКА (Decimal) ===")
from decimal import Decimal, getcontext
getcontext().prec = 50  # Повећај прецизност (број цифара које Decimal рачуна тачно)

a = Decimal('0.1')
b = Decimal('0.2')
c = Decimal('0.3')
x = Decimal('9007199254740993.0')
y = Decimal('9007199254740992.0')

print(a + b)    # 0.3
print(c / a)    # 3 
print(x - y)    # 1.0
