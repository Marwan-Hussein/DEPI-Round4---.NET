function setupScrollButton(id, targetTop) {
	const btn = document.getElementById(id);
	if (!btn) return;

	btn.addEventListener('mouseenter', () => {
		btn.style.transform = 'translateY(-5px) scale(1.05)';
		btn.style.boxShadow = '0 20px 25px -5px rgba(99, 102, 241, 0.5)';
	});

	btn.addEventListener('mouseleave', () => {
		btn.style.transform = 'translateY(0) scale(1)';
		btn.style.boxShadow = '0 10px 25px -5px rgba(99, 102, 241, 0.4)';
	});

	btn.addEventListener('click', () => {
		window.scrollTo({
			top: targetTop === 'bottom' ? document.documentElement.scrollHeight : 0,
			behavior: 'smooth'
		});
	});
}