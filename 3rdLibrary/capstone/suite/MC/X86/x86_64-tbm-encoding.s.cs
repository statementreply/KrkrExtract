# CS_ARCH_X86, CS_MODE_64, CS_OPT_SYNTAX_ATT
0x8f,0xea,0x78,0x10,0xc7,0xfe,0x0a,0x00,0x00 = bextr $2814, %edi, %eax
0x8f,0xea,0x78,0x10,0x07,0xfe,0x0a,0x00,0x00 = bextr $2814, (%rdi), %eax
0x8f,0xea,0xf8,0x10,0xc7,0xfe,0x0a,0x00,0x00 = bextr $2814, %rdi, %rax
0x8f,0xea,0xf8,0x10,0x07,0xfe,0x0a,0x00,0x00 = bextr $2814, (%rdi), %rax
0x8f,0xe9,0x78,0x01,0xcf = blcfill %edi, %eax
0x8f,0xe9,0x78,0x01,0x0f = blcfill (%rdi), %eax
0x8f,0xe9,0xf8,0x01,0xcf = blcfill %rdi, %rax
0x8f,0xe9,0xf8,0x01,0x0f = blcfill (%rdi), %rax
0x8f,0xe9,0x78,0x02,0xf7 = blci %edi, %eax
0x8f,0xe9,0x78,0x02,0x37 = blci (%rdi), %eax
0x8f,0xe9,0xf8,0x02,0xf7 = blci %rdi, %rax
0x8f,0xe9,0xf8,0x02,0x37 = blci (%rdi), %rax
0x8f,0xe9,0x78,0x01,0xef = blcic %edi, %eax
0x8f,0xe9,0x78,0x01,0x2f = blcic (%rdi), %eax
0x8f,0xe9,0xf8,0x01,0xef = blcic %rdi, %rax
0x8f,0xe9,0xf8,0x01,0x2f = blcic (%rdi), %rax
0x8f,0xe9,0x78,0x02,0xcf = blcmsk %edi, %eax
0x8f,0xe9,0x78,0x02,0x0f = blcmsk (%rdi), %eax
0x8f,0xe9,0xf8,0x02,0xcf = blcmsk %rdi, %rax
0x8f,0xe9,0xf8,0x02,0x0f = blcmsk (%rdi), %rax
0x8f,0xe9,0x78,0x01,0xdf = blcs %edi, %eax
0x8f,0xe9,0x78,0x01,0x1f = blcs (%rdi), %eax
0x8f,0xe9,0xf8,0x01,0xdf = blcs %rdi, %rax
0x8f,0xe9,0xf8,0x01,0x1f = blcs (%rdi), %rax
0x8f,0xe9,0x78,0x01,0xd7 = blsfill %edi, %eax
0x8f,0xe9,0x78,0x01,0x17 = blsfill (%rdi), %eax
0x8f,0xe9,0xf8,0x01,0xd7 = blsfill %rdi, %rax
0x8f,0xe9,0xf8,0x01,0x17 = blsfill (%rdi), %rax
0x8f,0xe9,0x78,0x01,0xf7 = blsic %edi, %eax
0x8f,0xe9,0x78,0x01,0x37 = blsic (%rdi), %eax
0x8f,0xe9,0xf8,0x01,0xf7 = blsic %rdi, %rax
0x8f,0xe9,0x78,0x01,0xff = t1mskc %edi, %eax
0x8f,0xe9,0x78,0x01,0x3f = t1mskc (%rdi), %eax
0x8f,0xe9,0xf8,0x01,0xff = t1mskc %rdi, %rax
0x8f,0xe9,0xf8,0x01,0x3f = t1mskc (%rdi), %rax
0x8f,0xe9,0x78,0x01,0xe7 = tzmsk %edi, %eax
0x8f,0xe9,0x78,0x01,0x27 = tzmsk (%rdi), %eax
0x8f,0xe9,0xf8,0x01,0xe7 = tzmsk %rdi, %rax
0x8f,0xe9,0xf8,0x01,0x27 = tzmsk (%rdi), %rax
